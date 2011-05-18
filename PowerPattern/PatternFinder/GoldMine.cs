using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFinder
{
	/// <summary>
	/// Represents the analysed data. Core data structure. This is serialized/deserialized to file for persistance.
	/// </summary>
	public class GoldMine
	{
		public List<double> RechargeHistory { get; set; }
		/// <summary>
		/// Computed from RechargeHistory
		/// </summary>
		public double RechargeFactor { get; } // TODOH

		public List<double> DischargeHistory { get; set; }
		/// <summary>
		/// Computed from DischargeHistory
		/// </summary>
		public double DischargeFactor { get; } // TODOH

		/// <summary>
		/// This is the max size of running average.
		/// </summary>
		public int WindowSize { get; set; } // assert in set, this can't be less than current list element count

		public override bool Equals(object obj)
		{
			return base.Equals(obj); // TODOH for UT to see two mines are equal
		}
	}
}
