using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task6.V10.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2023, m = 01, n = 01;
            string res = ds.FindDateOfPreviousDay(g, m, n), wait = "31.12.2022";
            Assert.AreEqual(wait, res);
        }
    }
}
