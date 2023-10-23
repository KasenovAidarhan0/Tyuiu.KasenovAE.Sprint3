﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.Task5.V5.Lib;

namespace Tyuiu.KasenovAE.Sprint3.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeries()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Assert.AreEqual(res, 98.286);
        }
    }
}
