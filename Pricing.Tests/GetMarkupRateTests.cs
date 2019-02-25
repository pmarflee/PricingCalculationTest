using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using Pricing.Tests.TestData;
using System;

namespace Pricing.Tests
{
    [TestClass]
    public class GetMarkupRateTests
    {
        private IQueryHandler<GetMarkupRateQuery, MarkupRate> GetMarkupRateQueryHandler;

        [TestInitialize]
        public void TestInitialize()
        {
            GetMarkupRateQueryHandler = new GetMarkupRateQueryHandler(MarkupRates.All);
        }

        /// <summary>
        /// Tests that a markup rate for Dollars can be found that is applicable on 30/03/2015 with a rate of 20%
        /// </summary>
        [TestMethod]
        public void GetMarkupRateForCurrencyUSDAndDepartureDate20150330ShouldReturnRateOf20Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(new GetMarkupRateQuery(new DateTime(2015, 3, 30), Currencies.USD));

            Assert.IsNotNull(rate);
            Assert.AreEqual(Currencies.USD, rate.Currency);
            Assert.AreEqual(20M, rate.PercentageRate);
        }

        /// <summary>
        /// Tests that a markup rate for Pounds can be found that is applicable on 25/07/2015 with a rate of 18%
        /// </summary>
        [TestMethod]
        public void GetMarkupRateForCurrencyGBPAndDepartureDate20150725ShouldReturnRateOf18Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(new GetMarkupRateQuery(new DateTime(2015, 7, 25), Currencies.GBP));

            Assert.IsNotNull(rate);
            Assert.AreEqual(Currencies.GBP, rate.Currency);
            Assert.AreEqual(18M, rate.PercentageRate);
        }

        /// <summary>
        /// Tests that a markup rate for Euros can be found that is applicable on 03/12/2015 with a rate of 35%
        /// </summary>
        [TestMethod]
        public void GetMarkupRateForCurrencyEURAndDepartureDate20151203ShouldReturnRateOf35Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(new GetMarkupRateQuery(new DateTime(2015, 12, 3), Currencies.EUR));

            Assert.IsNotNull(rate);
            Assert.AreEqual(Currencies.EUR, rate.Currency);
            Assert.AreEqual(35M, rate.PercentageRate);
        }
    }
}
