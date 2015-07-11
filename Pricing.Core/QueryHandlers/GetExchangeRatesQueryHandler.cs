using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.QueryHandlers
{
    public class GetExchangeRatesQueryHandler : IQueryHandler<GetExchangeRatesQuery, IEnumerable<ExchangeRate>>
    {
        private static ExchangeRate[] _exchangeRates = {
                                                           new ExchangeRate(Currency.USD, Currency.EUR, 1.11560M),
                                                           new ExchangeRate(Currency.EUR, Currency.USD, 0.89638M),
                                                           new ExchangeRate(Currency.USD, Currency.GBP, 1.55160M),
                                                           new ExchangeRate(Currency.GBP, Currency.USD, 0.64450M),
                                                           new ExchangeRate(Currency.EUR, Currency.GBP, 1.39082M),
                                                           new ExchangeRate(Currency.GBP, Currency.EUR, 0.71900M)
                                                       };

        public IEnumerable<ExchangeRate> Handle(GetExchangeRatesQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
