using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace StatOperations.Tests
{
    [TestClass()]
    public class VarianceTests
    {
        private readonly int[] arrayA = { 1, 2, 3, 4, 5 };
        private readonly int[] arrayB = { -2, -1, 0, 1, 2 };
        private readonly int a = 4;
        ArrayList subarray = new ArrayList();

        private readonly int mean = 3;
        [TestMethod()]
        public void VariancesTest()
        {
            //Variance.Variances(arrayA, mean);
            subarray = Variance.Variances(arrayA, mean);
            bool a = subarray.SequenceEqual(arrayB);
            Assert.AreEqual("True", a);
        }

        [TestMethod()]
        public void VariancesTest1()
        {
            Assert.AreEqual(1, Variance.Variances(a, mean));
        }
    }
}