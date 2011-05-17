using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainForm
{
	public class DataUnit
	{
		public DateTime TimeStamp { get; set; }
		public double? BatteryStatus { get; set; }
		public bool? PowerStatus { get; set; }
		public bool? Standby { get; set; }
	}
}
