using System.Collections.Generic;
using Pricing.Core.Models;
using Pricing.Core.Queries;

namespace Pricing.Core.QueryHandlers
{
    /// <summary>
    /// Executes a query for fetching an exchange rate
    /// </summary>
    public class GetExchangeRateQueryHandler : IQueryHandler<GetExchangeRateQuery, ExchangeRate>
    {
        private readonly IEnumerable<ExchangeRate> _exchangeRates;

        public GetExchangeRateQueryHandler(IEnumerable<ExchangeRate> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        /// <summary>
        /// Executes the query and returns the results
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The exchange rate if found, or a null reference if there was no match</returns>
        public ExchangeRate Handle(GetExchangeRateQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}
