using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;

namespace Pricing.Core.QueryHandlers
{
    public class GetCurrencyQueryHandler : IQueryHandler<GetCurrencyQuery, Currency>
    {
        private static readonly Currency[] _currencies = {
            Currency.USD,
            Currency.EUR,
            Currency.GBP
        };

        public Currency Handle(GetCurrencyQuery query)
        {
            // TODO: return the currency that matches the specified code

            throw new NotImplementedException();
        }
    }
}
