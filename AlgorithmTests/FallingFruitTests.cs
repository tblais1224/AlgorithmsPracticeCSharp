using System;
using System.Collections.Generic;
using AlgorithmsPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AlgorithmTests
{
    [TestFixture]
    public class FallingFruitTests
    {
        [Test]
        public void TestMethod1()
        {
            //int s, int t, int a, int b, int[] apples, int[] oranges
            int HouseStart = 7;
            int HouseEnd = 11;
            int AppleTree = 5;
            int OrangeTree = 15;
            List<int> apples = new List<int>() { -2, 2, 1 };
            List<int> oranges = new List<int>() { 5, -6 };
            List<int> expected = new List<int>() { 1, 1 };
            var fallingFruit = new FallingFruit(HouseStart, HouseEnd, AppleTree, OrangeTree, apples, oranges);
            Assert.AreEqual(expected, fallingFruit.FallingOnHouse());
        }
    }
}
