using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFinder
{
	public class DataUnit
	{
		/// <summary>
		/// Time stamp for this data
		/// </summary>
		public DateTime TimeStamp { get; set; }
		/// <summary>
		/// Percent of battery level
		/// </summary>
		public double? BatteryStatus { get; set; }
		/// <summary>
		/// true means charging, false means running on battery
		/// </summary>
		public bool? PowerStatus { get; set; }
		/// <summary>
		/// true means standby started, false means standby done
		/// </summary>
		public bool? Standby { get; set; }
	}
}
