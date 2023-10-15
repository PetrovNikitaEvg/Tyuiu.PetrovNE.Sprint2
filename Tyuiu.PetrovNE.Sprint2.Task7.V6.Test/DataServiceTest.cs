using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task7.V6.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
