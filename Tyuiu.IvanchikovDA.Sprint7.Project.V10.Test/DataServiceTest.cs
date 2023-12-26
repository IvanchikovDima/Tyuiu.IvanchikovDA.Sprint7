using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint7.Project.V10.Lib;

namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest  
    {
        [TestMethod]
        public void GetPriceTrueorFalse()
        {
            PriceItems priceItems = new PriceItems();
            string item = "молоко 1л";
            int res = priceItems.GetPrice(item);
            int wait = 80;
            Assert.AreEqual(wait, res);
        }
    }
}
