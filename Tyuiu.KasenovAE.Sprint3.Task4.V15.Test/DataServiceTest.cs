using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task4.V15.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-5, 5);
            Assert.AreEqual(res, 623.499);
        }
    }
}
