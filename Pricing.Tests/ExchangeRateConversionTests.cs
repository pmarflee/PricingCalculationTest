using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Tests.TestData;

namespace Pricing.Tests
{
    [TestClass]
    public class ExchangeRateConversionTests
    {
        /// <summary>
        /// Tests the exchange rate conversion of a price from Euros to Dollars
        /// </summary>
        [TestMethod]
        public void ConvertPriceFromEURToUSD()
        {
            var priceUSDExpected = new Price(278.9M, Currencies.USD);
            var priceUSDActual = ExchangeRates.EURToUSD.Convert(new Price(250M, Currencies.EUR));

            Assert.AreEqual(priceUSDExpected, priceUSDActual);
        }

        /// <summary>
        /// Tests the exchange rate conversion of a price from Dollars to Pounds
        /// </summary>
        [TestMethod]
        public void ConvertPriceFromUSDToGBP()
        {
            var priceGBPExpected = new Price(161.12M, Currencies.GBP);
            var priceGBPActual = ExchangeRates.USDToGBP.Convert(new Price(250M, Currencies.USD));

            Assert.AreEqual(priceGBPExpected, priceGBPActual);
        }

        /// <summary>
        /// Tests the exchange rate conversion of a price from Pounds to Euros
        /// </summary>
        [TestMethod]
        public void ConvertPriceFromGBPToEUR()
        {
            var priceEURExpected = new Price(347.71M, Currencies.EUR);
            var priceEURActual = ExchangeRates.GBPToEUR.Convert(new Price(250M, Currencies.GBP));

            Assert.AreEqual(priceEURExpected, priceEURActual);
        }
    }
}
