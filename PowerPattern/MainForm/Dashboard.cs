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
using System.Diagnostics;

namespace MainForm
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();

			AddDataUnit(GetDataUnitNow());

			int interval;
			if(!Int32.TryParse(ConfigurationManager.AppSettings["TimerInterval"], out interval))
			{
				interval = 30000; // default
			}

			GetDebugInterval(ref interval);

			timer1.Interval = interval;
			timer1.Start();
		}

		[Conditional("DEBUG")]
		private void GetDebugInterval(ref int interval)
		{
			interval = 1000;//1 sec
		}

		delegate void AddDataUnitCallback(DataUnit dt);
		private void AddDataUnit(DataUnit dt)
		{
			if (InvokeRequired)
			{
				this.Invoke(new AddDataUnitCallback(AddDataUnit), new object[] { dt });
			}
			else
			{
				dataUnitBindingSource.Add(dt);
				if (dt.Standby.HasValue == false)
				{
					this.progressBar1.Value = (int)(dt.BatteryLifePercent * 100);
					this.lblBatteryStatusPercent.Text = this.progressBar1.Value.ToString() + "%";
					this.lblPowerStatus.Text = dt.BatteryChargeStatus ? "Charging" : "Battery";
					this.lblTimeFullyCharged.Text = GetPredictionToCharge(dt.BatteryLifePercent).ToString();
					this.lblTimeLeftFullyDischarged.Text = GetPredictionToDischarge(dt.BatteryLifePercent).ToString();
				}
			}
		}

		private TimeSpan GetPredictionToDischarge(double p)
		{
			// Current it takes five 30secs = 2.5minutes to drop by 1 percent.
			int minutesLeft = (int)(p * 100 * 2.5);
			return new TimeSpan(0, minutesLeft,0);
		}

		private TimeSpan GetPredictionToCharge(double p)
		{
			// Current it takes 10 30secs = 5 minutes to get up by 1 percent.
			int minutesLeft = (int)((100 - p * 100) * 5);
			return new TimeSpan(0, minutesLeft, 0);
		}

			// TODOH add another background thread to monitor stuff and updateUI state and add to datagrid
			// TODOH DECESION this 2nd thread will wait till primary file load thread is done?
			// TODOH DECESION this 2nd thread will wait till what to write back to file?
			// TODOH DECESION Sync queue again?

		private void timer1_Tick(object sender, EventArgs e)
		{
			DataUnit dt = GetDataUnitNow();
			dt.Standby = null;
			AddDataUnit(dt);
		}

		private DataUnit GetDataUnitNow()
		{
			PowerStatus ps = SystemInformation.PowerStatus;
			DataUnit dt = new DataUnit()
			{
				TimeStamp = DateTime.Now,
				BatteryChargeStatus = ps.BatteryChargeStatus == BatteryChargeStatus.Charging ? true : false,
				BatteryLifePercent = ps.BatteryLifePercent,
			};
			return dt;
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
					{
						DataUnit dt = GetDataUnitNow();
						dt.Standby = true;
						AddDataUnit(dt);
					}
					break;
				case OSEvents.StandbyEnd:
					{
						DataUnit dt = GetDataUnitNow();
						dt.Standby = false;
						AddDataUnit(dt);
					}
					break;
				default:
					break;
			}

			base.WndProc(ref m);
		}
	}
}
