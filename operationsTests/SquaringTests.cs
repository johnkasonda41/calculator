﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SquaringTests
    {
        private readonly int a = 5;
        private readonly double b = 10.8;


        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(25, Squaring.Square(a));
        }

        [TestMethod()]
        public void SquareDouble()
        {
            Assert.AreEqual(116.64000000000001, Squaring.Square(b));
        }
    }
}