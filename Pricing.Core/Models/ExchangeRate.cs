using System;

namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents a conversion rate between two currencies
    /// </summary>
    public class ExchangeRate
    {
        public ExchangeRate(Currency from, Currency to, decimal rate)
        {
            From = from;
            To = to;
            Rate = rate;
        }

        /// <summary>
        /// The currency to convert from
        /// </summary>
        public Currency From { get; }

        /// <summary>
        /// The currency to convert to
        /// </summary>
        public Currency To { get; }

        /// <summary>
        /// The conversion rate, expressed as a decimal fraction between 0 and 1.
        /// </summary>
        public decimal Rate { get; }

        /// <summary>
        /// Converts a price from a local currency to a selling currency
        /// </summary>
        /// <param name="price">The price to convert</param>
        /// <returns>A new price instance, representing the price converted to the selling ('To') currency</returns>
        public Price Convert(Price price)
        {
            // To perform a currency conversion, divide the local price by the conversion rate
            // and return a new price instance using the 'To' (selling) currency.
            // Prices should be rounded to 2dp.

            throw new NotImplementedException();
        }

        public override bool Equals(object obj) => 
            obj is ExchangeRate other ? From == other.From && To == other.To && Rate == other.Rate : false;

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + From.GetHashCode();
                hash = hash * 23 + To.GetHashCode();
                hash = hash * 23 + Rate.GetHashCode();
                return hash;
            }
        }
    }
}
