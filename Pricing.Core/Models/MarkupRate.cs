using System;

namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents the markup rate for a price
    /// </summary>
    public class MarkupRate
    {
        /// <summary>
        /// Creates a new markup rate, using the given from/to dates, currency, and percentage rate
        /// </summary>
        /// <param name="from">Date the rate is applicable from</param>
        /// <param name="to">Date the rate is applicable to</param>
        /// <param name="currency">Currency for the rate</param>
        /// <param name="percentageRate">Percentage rate to mark up the price by, expressed as a decimal value between 0 and 100</param>
        public MarkupRate(DateTime from, DateTime to, Currency currency, decimal percentageRate)
        {
            From = from;
            To = to;
            Currency = currency;
            PercentageRate = percentageRate;
        }
        /// <summary>
        /// Date the rate is applicable from
        /// </summary>
        public DateTime From { get; }

        /// <summary>
        /// Date the rate is applicable to
        /// </summary>
        public DateTime To { get; }

        /// <summary>
        /// Currency for the rate
        /// </summary>
        public Currency Currency { get; }

        /// <summary>
        /// Percentage rate to mark up the price by, expressed as a decimal value between 0 and 100
        /// </summary>
        public decimal PercentageRate { get; }

        /// <summary>
        /// Marks up a price by the percentage rate
        /// </summary>
        /// <param name="price">The price to mark up</param>
        /// <returns>A new price instance that represents the marked up price</returns>
        public Price Markup(Price price)
        {
            // To mark up a price, return a value equal to the current price
            // plus the proportion of the value indicated by PercentageRate

            // The price returned should be rounded to 2dp

            throw new NotImplementedException();
        }
    }
}
