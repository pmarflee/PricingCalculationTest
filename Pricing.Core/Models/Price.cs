using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Models
{
    public struct Price
    {
        public Price(decimal amount, Currency currency) : this()
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }

        public override string ToString()
        {
            return Currency.Symbol + Amount.ToString("0.00");
        }
    }
}
