using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using Pricing.Tests.TestData;

namespace Pricing.Tests
{
    [TestClass]
    public class GetExchangeRateTests
    {
        private IQueryHandler<GetExchangeRateQuery, ExchangeRate> GetExchangeRateQueryHandler;

        [TestInitialize]
        public void TestInitialize()
        {
            GetExchangeRateQueryHandler = new GetExchangeRateQueryHandler(ExchangeRates.All);
        }

        /// <summary>
        /// Tests that an exchange rate can be found that converts Euros to Dollars
        /// </summary>
        [TestMethod]
        public void GetExchangeRateEURToUSD()
        {
            var expected = ExchangeRates.EURToUSD;
            var actual = GetExchangeRateQueryHandler.Handle(new GetExchangeRateQuery(Currencies.EUR, Currencies.USD));

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that an exchange rate can be found that converts Dollars to Pounds
        /// </summary>
        [TestMethod]
        public void GetExchangeRateUSDToGBP()
        {
            var expected = ExchangeRates.USDToGBP;
            var actual = GetExchangeRateQueryHandler.Handle(new GetExchangeRateQuery(Currencies.USD, Currencies.GBP));

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that an exchange rate can be found that converts Pounds to Euros
        /// </summary>
        [TestMethod]
        public void GetExchangeRateGBPToEUR()
        {
            var expected = ExchangeRates.GBPToEUR;
            var actual = GetExchangeRateQueryHandler.Handle(new GetExchangeRateQuery(Currencies.GBP, Currencies.EUR));

            Assert.AreEqual(expected, actual);
        }
    }
}
