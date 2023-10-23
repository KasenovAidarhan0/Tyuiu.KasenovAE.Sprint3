using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task6.V25.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(16, 24);
            Assert.AreEqual(res, 89);
        }
    }
}
