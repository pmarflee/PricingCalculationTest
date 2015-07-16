using System.Linq;
using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;

namespace Pricing.Core.QueryHandlers
{
    public class GetMarkupRateQueryHandler : IQueryHandler<GetMarkupRateQuery, MarkupRate>
    {
        private static readonly MarkupRate[] MarkupRates =
        {
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currency.USD, 20),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currency.USD, 25),
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currency.GBP, 15),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currency.GBP, 18),
            new MarkupRate(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), Currency.EUR, 30),
            new MarkupRate(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), Currency.EUR, 35),
        };

        public MarkupRate Handle(GetMarkupRateQuery query)
        {
            return MarkupRates.FirstOrDefault(rate =>
                rate.Currency.Equals(query.Currency) &&
                query.DepartureDate >= rate.From && query.DepartureDate <= rate.To);
        }
    }
}