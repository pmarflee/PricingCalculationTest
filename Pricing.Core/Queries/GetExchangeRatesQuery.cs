using Pricing.Core.Models;
using System.Collections.Generic;

namespace Pricing.Core.Queries
{
    public class GetExchangeRatesQuery : IQuery<IEnumerable<ExchangeRate>>
    {
        /// <summary>
        /// The currency to convert to
        /// </summary>
        public Currency To { get; set; }
    }
}
