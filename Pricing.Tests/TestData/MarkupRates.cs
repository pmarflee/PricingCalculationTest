using System;
using System.Collections.Generic;
using Pricing.Core.Models;

namespace Pricing.Tests.TestData
{
    static class MarkupRates
    {
        public static readonly IEnumerable<MarkupRate> All = new[]
        {
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currencies.USD, 20),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currencies.USD, 25),
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currencies.GBP, 15),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currencies.GBP, 18),
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currencies.EUR, 30),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currencies.EUR, 35),
        };
    }
}
