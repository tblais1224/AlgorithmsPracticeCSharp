using System;
using System.Collections.Generic;
using AlgorithmsPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AlgorithmTests
{
    [TestFixture]
    public class SumAllInRange
    {
        [TestCase(10, new int[] { 1, 4 })]
        [TestCase(10, new int[] { 4, 1 })]
        [TestCase(45, new int[] { 5, 10 })]
        [TestCase(45, new int[] { 10, 5 })]
        public void TestMethod1(int expected, int[] value)
        {
            var testMe = new SumAll(value);
            Assert.AreEqual(expected, testMe.SumArray());
        }
    }
}
