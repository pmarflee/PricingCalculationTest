using System.Linq;
using Pricing.Core.Models;
using Pricing.Core.Queries;

namespace Pricing.Core.QueryHandlers
{
    public class GetCurrencyQueryHandler : IQueryHandler<GetCurrencyQuery, Currency>
    {
        private static readonly Currency[] Currencies = {
            Currency.USD,
            Currency.EUR,
            Currency.GBP
        };

        public Currency Handle(GetCurrencyQuery query)
        {
            return Currencies.FirstOrDefault(c => c.Code == query.Code);
        }
    }
}
