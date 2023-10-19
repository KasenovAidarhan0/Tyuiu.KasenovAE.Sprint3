using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task0.V28.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeries()
        {
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(0.25, 1, 17);
            Assert.AreEqual(res, 411589.537);
        }
    }
}
