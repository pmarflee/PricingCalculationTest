using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using Pricing.Core.Services;
using Pricing.Tests.TestData;
using System.Linq;

namespace Pricing.Tests
{
    [TestClass]
    public class TourDeparturePriceCalculationTests
    {
        private IQueryHandler<GetExchangeRateQuery, ExchangeRate> GetExchangeRateQueryHandler;
        private IQueryHandler<GetMarkupRateQuery, MarkupRate> GetMarkupRateQueryHandler;
        private TourDeparturePricingService TourDeparturePricingService;

        [TestInitialize]
        public void TestInitialize()
        {
            GetExchangeRateQueryHandler = new GetExchangeRateQueryHandler(ExchangeRates.All);
            GetMarkupRateQueryHandler = new GetMarkupRateQueryHandler(MarkupRates.All);
            TourDeparturePricingService = new TourDeparturePricingService(GetExchangeRateQueryHandler, GetMarkupRateQueryHandler);
        }

        /// <summary>
        /// Tests that a selling price is calculated in the same currency when the local and selling currencies are the same
        /// </summary>
        [TestMethod]
        public void TourDeparturePricingServiceShouldCalculatePriceInLocalCurrencyWhenLocalAndSellingCurrenciesAreSame()
        {
            var tourDeparture = TourDepartures.All.First();

            var result = TourDeparturePricingService.CalculatePrice(tourDeparture, tourDeparture.LocalCost.Currency);

            Assert.AreEqual(tourDeparture, result.TourDeparture);
            Assert.AreEqual(575M, result.SellingPrice.Amount);
            Assert.AreEqual(Currencies.GBP, result.SellingPrice.Currency);
        }

        /// <summary>
        /// Tests that a selling price is calculated in the selling currency when the local and selling currencies are not the same
        /// </summary>
        [TestMethod]
        public void TourDeparturePricingServiceShouldCalculatePriceInSellingCurrencyWhenLocalAndSellingCurrenciesAreNotSame()
        {
            var tourDeparture = TourDepartures.All.Skip(1).First();

            var result = TourDeparturePricingService.CalculatePrice(tourDeparture, Currencies.USD);

            Assert.AreEqual(tourDeparture, result.TourDeparture);
            Assert.AreEqual(969.75M, result.SellingPrice.Amount);
            Assert.AreEqual(Currencies.USD, result.SellingPrice.Currency);
        }
    }
}
