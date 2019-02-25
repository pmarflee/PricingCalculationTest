using System.Collections.Generic;
using Pricing.Core.Models;

namespace Pricing.Tests.TestData
{
    static class ExchangeRates
    {
        /// <summary>
        /// Dollars to Euros
        /// </summary>
        public static ExchangeRate USDToEUR = new ExchangeRate(Currencies.USD, Currencies.EUR, 1.11560M);

        /// <summary>
        /// Euros to Dollars
        /// </summary>
        public static ExchangeRate EURToUSD = new ExchangeRate(Currencies.EUR, Currencies.USD, 0.89638M);

        /// <summary>
        /// Dollars to Pounds
        /// </summary>
        public static ExchangeRate USDToGBP = new ExchangeRate(Currencies.USD, Currencies.GBP, 1.55160M);

        /// <summary>
        /// Pounds to Dollars
        /// </summary>
        public static ExchangeRate GBPToUSD = new ExchangeRate(Currencies.GBP, Currencies.USD, 0.64450M);

        /// <summary>
        /// Euros to Pounds
        /// </summary>
        public static ExchangeRate EURToGBP = new ExchangeRate(Currencies.EUR, Currencies.GBP, 1.39082M);

        /// <summary>
        /// Pounds to Euros
        /// </summary>
        public static ExchangeRate GBPToEUR = new ExchangeRate(Currencies.GBP, Currencies.EUR, 0.71900M);

        public static IEnumerable<ExchangeRate> All = new[]
        {
            USDToEUR, EURToUSD, USDToGBP, GBPToUSD, EURToGBP, GBPToEUR
        };
    }
}
