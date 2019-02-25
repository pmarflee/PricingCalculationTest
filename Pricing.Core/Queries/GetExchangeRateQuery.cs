using Pricing.Core.Models;

namespace Pricing.Core.Queries
{
    /// <summary>
    /// Query criteria for fetching an exchange rate
    /// </summary>
    public class GetExchangeRateQuery : IQuery<ExchangeRate>
    {
        public GetExchangeRateQuery(Currency from, Currency to)
        {
            From = from;
            To = to;
        }

        /// <summary>
        /// The currency to convert from
        /// </summary>
        public Currency From { get; }

        /// <summary>
        /// The currency to convert to
        /// </summary>
        public Currency To { get; }
    }
}
