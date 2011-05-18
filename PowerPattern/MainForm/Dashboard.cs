using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using PatternFinder;

namespace MainForm
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
			//backgroundWorker1.RunWorkerAsync();
			int interval;
			if(!Int32.TryParse(ConfigurationManager.AppSettings["TimerInterval"], out interval))
			{
				interval = 30000; // default
			}

			timer1.Interval = interval;
			timer1.Start();
		}

		delegate void AddDataUnitCallback(DataUnit dt);
		private void AddDataUnit(DataUnit dt)
		{
			if (InvokeRequired)
			{
				//dataUnitBindingSource.Add(dt);
				this.Invoke(new AddDataUnitCallback(AddDataUnit), new object[] { dt });
			}
			else
			{
				dataUnitBindingSource.Add(dt);
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			DataUnit dt = e.Argument as DataUnit;
			//loadDataFromFile.On
			for (int i = 0; i < 100; i++)
			{
				AddDataUnit(
					new DataUnit()
					{
						BatteryStatus = 100 - i,
						PowerStatus = i % 2 == 0 ? true : false,
						TimeStamp = DateTime.Now
					});

				Thread.Sleep(100);
			}

			// TODOH add another background thread to monitor stuff and updateUI state and add to datagrid
			// TODOH DECESION this 2nd thread will wait till primary file load thread is done?
			// TODOH DECESION this 2nd thread will wait till what to write back to file?
			// TODOH DECESION Sync queue again?

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			PowerStatus ps = SystemInformation.PowerStatus;
			AddDataUnit(new DataUnit()
			{
				TimeStamp = DateTime.Now,
				PowerStatus = ps.BatteryChargeStatus == BatteryChargeStatus.Charging ? true : false,
				BatteryStatus = ps.BatteryLifePercent,
				Standby = null
			});
		}

		/// <summary>
		/// Overloaded System Windows Handler.
		/// </summary>
		/// <param name="m">Message <see cref="Message"/> structure</param>
		protected override void WndProc(ref Message m)
		{
			switch (Win32EventHandler.Handle(ref m))
			{
				case OSEvents.None:
					break;
				case OSEvents.StandbyStarted:
					AddDataUnit(new DataUnit() { TimeStamp = DateTime.Now, Standby = true });
					break;
				case OSEvents.StandbyEnd:
					AddDataUnit(new DataUnit() { TimeStamp = DateTime.Now, Standby = false });
					break;
				default:
					break;
			}

			base.WndProc(ref m);
		}
	}
}
