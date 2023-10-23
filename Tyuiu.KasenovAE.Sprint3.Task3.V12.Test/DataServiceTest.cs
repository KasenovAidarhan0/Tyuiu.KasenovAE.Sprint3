using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task3.V12.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetMaxCharCount("bkkrk ckkkcs ksr", 'k');
            Assert.AreEqual(res, 4);
        }
    }
}
