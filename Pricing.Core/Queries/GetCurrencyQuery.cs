using Pricing.Core.Models;

namespace Pricing.Core.Queries
{
    public class GetCurrencyQuery : IQuery<Currency>
    {
        /// <summary>
        /// The currency code
        /// </summary>
        public string Code { get; set; }
    }
}
