using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using Pricing.Core.Services;

namespace Pricing.Tests
{
    [TestClass]
    public class PricingTests
    {
        private IQueryHandler<GetExchangeRateQuery, ExchangeRate> GetExchangeRateQueryHandler;
        private IQueryHandler<GetMarkupRateQuery, MarkupRate> GetMarkupRateQueryHandler;
        private TourDeparturePricingService TourDeparturePricingService;

        [TestInitialize]
        public void TestInitialize()
        {
            GetExchangeRateQueryHandler = new GetExchangeRateQueryHandler(ExchangeRateTestData.All);
            GetMarkupRateQueryHandler = new GetMarkupRateQueryHandler(MarkupRateTestData.All);
            TourDeparturePricingService = new TourDeparturePricingService(
                GetExchangeRateQueryHandler, GetMarkupRateQueryHandler);
        }

        [TestMethod]
        public void ConvertPriceFromEURToUSD()
        {
            var priceEUR = new Price(250, CurrencyTestData.EUR);
            var priceUSDExpected = new Price(278.9M, CurrencyTestData.USD);
            ExchangeRate exchangeRateEURToUSD = null;

            var priceUSDActual = exchangeRateEURToUSD.Convert(priceEUR);

            Assert.AreEqual(priceUSDExpected, priceUSDActual);
        }

        [TestMethod]
        public void ConvertPriceFromUSDToGBP()
        {
            var priceUSD = new Price(250, CurrencyTestData.USD);
            var priceGBPExpected = new Price(161.12M, CurrencyTestData.GBP);
            ExchangeRate exchangeRateUSDToGBP = null;

            var priceGBPActual = exchangeRateUSDToGBP.Convert(priceUSD);

            Assert.AreEqual(priceGBPExpected, priceGBPActual);
        }

        [TestMethod]
        public void ConvertPriceFromGBPToEUR()
        {
            var priceGBP = new Price(250, CurrencyTestData.GBP);
            var priceEURExpected = new Price(347.71M, CurrencyTestData.EUR);
            ExchangeRate exchangeRateGBPToEUR = null;

            var priceEURActual = exchangeRateGBPToEUR.Convert(priceGBP);

            Assert.AreEqual(priceEURExpected, priceEURActual);
        }

        [TestMethod]
        public void GetExchangeRateEURToUSD()
        {
            var expected = ExchangeRateTestData.EURToUSD;
            var actual = GetExchangeRateQueryHandler.Handle(
                new GetExchangeRateQuery { From = CurrencyTestData.EUR, To = CurrencyTestData.USD });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetExchangeRateUSDToGBP()
        {
            var expected = ExchangeRateTestData.USDToGBP;
            var actual = GetExchangeRateQueryHandler.Handle(
                new GetExchangeRateQuery { From = CurrencyTestData.USD, To = CurrencyTestData.GBP });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetExchangeRateGBPToEUR()
        {
            var expected = ExchangeRateTestData.GBPToEUR;
            var actual = GetExchangeRateQueryHandler.Handle(
                new GetExchangeRateQuery { From = CurrencyTestData.GBP, To = CurrencyTestData.EUR });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMarkupRateForCurrencyUSDAndDepartureDate20150330ShouldReturnRateOf20Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(
                new GetMarkupRateQuery
                {
                    Currency = CurrencyTestData.USD,
                    DepartureDate = new DateTime(2015, 3, 30)
                });

            Assert.IsNotNull(rate);
            Assert.AreEqual(CurrencyTestData.USD, rate.Currency);
            Assert.AreEqual(20, rate.PercentageRate);
        }

        [TestMethod]
        public void GetMarkupRateForCurrencyGBPAndDepartureDate20150725ShouldReturnRateOf18Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(
                new GetMarkupRateQuery
                {
                    Currency = CurrencyTestData.GBP,
                    DepartureDate = new DateTime(2015, 7, 25)
                });

            Assert.IsNotNull(rate);
            Assert.AreEqual(CurrencyTestData.GBP, rate.Currency);
            Assert.AreEqual(18, rate.PercentageRate);
        }

        [TestMethod]
        public void GetMarkupRateForCurrencyEURAndDepartureDate20151203ShouldReturnRateOf35Percent()
        {
            var rate = GetMarkupRateQueryHandler.Handle(
                new GetMarkupRateQuery
                {
                    Currency = CurrencyTestData.EUR,
                    DepartureDate = new DateTime(2015, 12, 3)
                });

            Assert.IsNotNull(rate);
            Assert.AreEqual(CurrencyTestData.EUR, rate.Currency);
            Assert.AreEqual(35, rate.PercentageRate);
        }

        [TestMethod]
        public void MarkupRateMarkupShouldReturnMarkedUpPriceInSameCurrency()
        {
            var currency = CurrencyTestData.USD;
            var price = new Price(250M, currency);
            var markupRate = new MarkupRate(
                new DateTime(2017, 1, 1), new DateTime(2017, 12, 31), 
                currency, 25);

            var markedUpPrice = markupRate.Markup(price);

            Assert.AreEqual(currency, markedUpPrice.Currency);
            Assert.AreEqual(312.5, markedUpPrice.Amount);
        }

        [TestMethod]
        public void TourDeparturePricingServiceShouldCalculatePriceInLocalCurrencyWhenLocalAndSellingCurrenciesAreSame()
        {
            var tourDeparture = TourDepartureTestData.TourDepartures.First();

            var result = TourDeparturePricingService.CalculatePrice(tourDeparture, tourDeparture.LocalCost.Currency);

            Assert.AreEqual(tourDeparture, result.TourDeparture);
            Assert.AreEqual(575, result.SellingPrice.Amount);
            Assert.AreEqual(CurrencyTestData.GBP, result.SellingPrice.Currency);
        }

        [TestMethod]
        public void TourDeparturePricingServiceShouldCalculatePriceInSellingCurrencyWhenLocalAndSellingCurrenciesAreNotSame()
        {
            var tourDeparture = TourDepartureTestData.TourDepartures.Skip(1).First();

            var result = TourDeparturePricingService.CalculatePrice(tourDeparture, CurrencyTestData.USD);

            Assert.AreEqual(tourDeparture, result.TourDeparture);
            Assert.AreEqual(969.75, result.SellingPrice.Amount);
            Assert.AreEqual(CurrencyTestData.USD, result.SellingPrice.Currency);
        }
    }
}
