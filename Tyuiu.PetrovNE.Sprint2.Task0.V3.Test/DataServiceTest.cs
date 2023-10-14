using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.Task0.V3.Lib;

namespace Tyuiu.PetrovNE.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetComparedOperations()
        {
            DataService ds = new DataService();
            int x = 45, y = 127;
            bool[] result = new bool[6];
            result = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, result);


        }
    }
}
