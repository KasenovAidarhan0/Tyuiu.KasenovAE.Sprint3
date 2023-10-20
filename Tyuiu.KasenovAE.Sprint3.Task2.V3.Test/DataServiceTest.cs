using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task2.V3.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeries()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSeries(4, 1, 15);
            Assert.AreEqual(res, 1935);
        }
    }
}
