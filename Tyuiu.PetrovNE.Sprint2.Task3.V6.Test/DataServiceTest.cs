using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task3.V6.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidCondition1() // x > 0
        {
            double x = 3, res = ds.Calculate(x), wait = 4;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2() // x = 0
        {
            double x = 0, res = ds.Calculate(x), wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3() //-10 < x < 0
        {
            double x = (-1), res = ds.Calculate(x), wait = 0.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4() // x < -10
        {
            double x = -11, res = ds.Calculate(x), wait = -120.909;
            Assert.AreEqual(wait, res);
        }
    }
}
