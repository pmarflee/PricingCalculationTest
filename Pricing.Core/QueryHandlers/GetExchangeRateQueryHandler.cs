using System.Collections.Generic;
using Pricing.Core.Models;
using Pricing.Core.Queries;

namespace Pricing.Core.QueryHandlers
{
    public class GetExchangeRateQueryHandler : IQueryHandler<GetExchangeRateQuery, ExchangeRate>
    {
        private readonly IEnumerable<ExchangeRate> _exchangeRates;

        public GetExchangeRateQueryHandler(IEnumerable<ExchangeRate> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public ExchangeRate Handle(GetExchangeRateQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}
