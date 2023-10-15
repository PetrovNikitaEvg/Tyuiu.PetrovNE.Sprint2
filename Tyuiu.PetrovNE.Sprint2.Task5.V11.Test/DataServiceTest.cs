using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task5.V11.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNextDay()
        {
            DataService ds = new DataService();
            int g = 2022, m = 12, n = 31;
            string res = ds.FindDateOfNextDay(g, m, n), wait = "01.01.2023";
            Assert.AreEqual(wait, res);
        }

    }
}
