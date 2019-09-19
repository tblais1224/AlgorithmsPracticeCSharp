using System;
using System.Collections.Generic;
using AlgorithmsPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AlgorithmTests
{
    [TestFixture]
    public class GradingTests
    {
        [Test]
        public void TestMethod1()
        {
            List<int> grades = new List<int>() { 73, 67, 38, 33 };
            List<int> expected = new List<int>() { 75, 67, 40, 33 };
            var grader = new Grader(grades);
            Assert.AreEqual(expected, grader.GetFinalGrades());
        }
    }
}
