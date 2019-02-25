using System.Collections.Generic;
using Pricing.Core.Models;

namespace Pricing.Tests.TestData
{
    static class Currencies
    {
        /// <summary>
        /// US Dollars
        /// </summary>
        public static Currency USD = new Currency("USD", "$", "US dollar");

        /// <summary>
        /// Euros
        /// </summary>
        public static Currency EUR = new Currency("EUR", "€", "Euro");

        /// <summary>
        /// UK Pounds
        /// </summary>
        public static Currency GBP = new Currency("GBP", "£", "Pound sterling");

        public static IEnumerable<Currency> All = new[] { USD, EUR, GBP };
    }
}
