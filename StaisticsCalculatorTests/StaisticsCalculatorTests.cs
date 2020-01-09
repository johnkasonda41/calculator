using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaisticsCalculator.Tests
{
    [TestClass()]
    public class StaisticsCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StaisticsCalculator statsCal1 = new StaisticsCalculator();
            int[] values = { 1, 2};
            var mean = statsCal1.Mean(values);
            Assert.AreEqual(1, mean);
        }
    }
}