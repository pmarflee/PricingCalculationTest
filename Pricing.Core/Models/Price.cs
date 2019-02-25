namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents a price in a given currency
    /// </summary>
    public class Price
    {
        /// <summary>
        /// Creates a new price, using the given amount and currency
        /// </summary>
        /// <param name="amount">The amount</param>
        /// <param name="currency">The curency</param>
        public Price(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        /// <summary>
        /// The amount
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// The currency
        /// </summary>
        public Currency Currency { get; }

        public override string ToString() => $"{Currency.Symbol}{Amount.ToString("0.00")}";

        public override bool Equals(object obj) =>
            obj is Price other ? Amount == other.Amount && Currency == other.Currency : false;

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + Amount.GetHashCode();
                hash = hash * 23 + Currency.GetHashCode();
                return hash;
            }
        }
    }
}
