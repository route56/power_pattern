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

			for (int i = 0; i < 100; i++)
			{
				dataUnitBindingSource.Add(
					new DataUnit() 
					{ 
						BatteryStatus = 100 - i,
						PowerStatus = i % 2 == 0 ? true : false,
						TimeStamp = DateTime.Now
					});

				Thread.Sleep(100);
			}
			
			
			//DataTable table = new DataTable("Log");

			//table.Columns.Add(this.ColTimeStamp.Name, typeof(DateTime));
			//table.Columns.Add(this.ColBatteryStatus.Name, typeof(double));
			//table.Columns.Add(this.ColPowerStatus.Name, typeof(string));
			//table.Columns.Add(this.ColStandby.Name, typeof(string));


			//DataRow newRow = table.NewRow();

			//newRow[ColTimeStamp.Name] = DateTime.Now;
			//newRow[ColBatteryStatus.Name] = .60;
			//newRow[ColPowerStatus.Name] = "Discharging";
			//newRow[ColStandby.Name] = "";

			//table.Rows.Add(newRow);

			//this.dataSet1.Tables.Add(table);
		}
	}
}
