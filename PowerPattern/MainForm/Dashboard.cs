using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MainForm
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
			backgroundWorker1.RunWorkerAsync();
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
		}
	}
}
