using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task2.V16.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4, y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            
            Assert.AreEqual(true, res);
        }
    }
}
