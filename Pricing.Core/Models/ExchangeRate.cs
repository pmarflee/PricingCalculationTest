using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Models
{
    public class ExchangeRate
    {
        public ExchangeRate(Currency from, Currency to, decimal rate)
        {
            From = from;
            To = to;
            Rate = rate;
        }

        public Currency From { get; private set; }
        public Currency To { get; private set; }
        public decimal Rate { get; private set; }

        public Price Convert(Price price)
        {
            // To perform a currency conversion, divide the local price by the conversion rate
            // and return a new price in the selling currency

            throw new NotImplementedException();
        }
    }
}
