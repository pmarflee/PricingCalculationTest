using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Tests.TestData;
using System;

namespace Pricing.Tests
{
    [TestClass]
    public class MarkupCalculationTests
    {
        /// <summary>
        /// Tests that marking up a price returns a new price in the same currency, marked up by the specified percentage rate
        /// </summary>
        [TestMethod]
        public void MarkupRateMarkupShouldReturnMarkedUpPriceInSameCurrency()
        {
            var currency = Currencies.USD;
            var price = new Price(250M, currency);
            var markupRate = new MarkupRate(new DateTime(2017, 1, 1), new DateTime(2017, 12, 31), currency, 25M);
            var markedUpPrice = markupRate.Markup(price);

            Assert.AreEqual(currency, markedUpPrice.Currency);
            Assert.AreEqual(312.5M, markedUpPrice.Amount);
        }
    }
}
