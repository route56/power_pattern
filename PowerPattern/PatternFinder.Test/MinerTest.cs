using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternFinder.Test
{
	[TestClass]
	public class MinerTest
	{
		/// <summary>
		/// Data driven test.
		/// </summary>
		[TestMethod]
		public void GetPureObservationListFromDatatUnitList()
		{
			// Get data and expectations from GetPureObservationListFromDatatUnitList.csv file
			List<Tuple<List<DataUnit>, List<PureObservation>, string >> data = GetDataAndExpectationsFrom("GetPureObservationListFromDatatUnitList.csv");

			foreach (var item in data)
			{
				CollectionAssert.AreEqual(new Miner().GetPureObservation(item.Item1), item.Item2, item.Item3);
			}
		}

		private List<Tuple<List<DataUnit>, List<PureObservation>, string >> GetDataAndExpectationsFrom(string p)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Data driven test
		/// </summary>
		[TestMethod]
		public void AddingPureObservationShouldChangeGoldMine()
		{
			List<Tuple<GoldMine, PureObservation, GoldMine, string>> data = GetDataForAddingPureObservationShouldChangeGoldMine("AddingPureObservationShouldChangeGoldMine.csv");

			foreach (var item in data)
			{
				Assert.AreEqual(new Miner().AddPureObservationToGoldMine(item.Item1, item.Item2), item.Item3, item.Item4);
			}
		}

		private List<Tuple<GoldMine, PureObservation, GoldMine, string>> GetDataForAddingPureObservationShouldChangeGoldMine(string p)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Data driven test.
		/// </summary>
		[TestMethod]
		public void GetPureObservationListFromDatatUnitListWithStandbyInfoIncluded()
		{
			// Get data and expectations from GetPureObservationListFromDatatUnitListWithStandbyInfoIncluded.csv file
			List<Tuple<List<DataUnit>, List<PureObservation>, string>> data = GetDataAndExpectationsFrom("GetPureObservationListFromDatatUnitListWithStandbyInfoIncluded.csv");

			foreach (var item in data)
			{
				CollectionAssert.AreEqual(new Miner().GetPureObservation(item.Item1), item.Item2, item.Item3);
			}
		}
	}
}
