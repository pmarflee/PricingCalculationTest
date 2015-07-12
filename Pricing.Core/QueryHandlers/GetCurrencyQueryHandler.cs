using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.QueryHandlers
{
    public class GetCurrencyQueryHandler : IQueryHandler<GetCurrencyQuery, Currency>
    {
        private static Currency[] _currencies = { Currency.USD, Currency.EUR, Currency.GBP };

        public Currency Handle(GetCurrencyQuery query)
        {
            return _currencies.FirstOrDefault(currency => 
                currency.Code.Equals(query.Code, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
