namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents a currency e.g. USD, GBP
    /// </summary>
    public class Currency
    {
        public Currency(string code, string symbol, string description)
        {
            Code = code;
            Symbol = symbol;
            Description = description;
        }

        /// <summary>
        /// Currency code
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Currency symbol
        /// </summary>
        public string Symbol { get; }

        /// <summary>
        /// Currency description
        /// </summary>
        public string Description { get; }

        public override bool Equals(object obj) => obj is Currency other ? Code == other.Code : false;

        public override int GetHashCode() => Code.GetHashCode();

        public override string ToString() => Code;
    }
}
