using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task4.V6.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            double x = 1, y = 1, res = ds.Calculate(x, y), wait = 0.667;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            double x = 1, y = 15, res = ds.Calculate(x, y), wait = 233;
            Assert.AreEqual(wait, res);
        }
        DataService ds = new DataService();
    }
}
