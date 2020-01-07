using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 5;
        private readonly int max = 10;

        [TestMethod()]
        public void RandomiseTest()
        {
            //Assert.AreEqual(Randomising.Randomise(min, max), Randomising.Randomise(min, max));
        }
    }
}