using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Models
{
    public struct Currency
    {
        public Currency(string code, string symbol, string description) : this()
        {
            Code = code;
            Symbol = symbol;
            Description = description;
        }

        public string Code { get; private set; }
        public string Symbol { get; private set; }
        public string Description { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj is Currency)
            {
                Currency other = (Currency)obj;
                return this.Code == other.Code;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.Code.GetHashCode();
        }

        public override string ToString()
        {
            return Code;
        }

        public static Currency USD = new Currency("USD", "$", "US dollar");
        public static Currency EUR = new Currency("EUR", "€", "Euro");
        public static Currency GBP = new Currency("GBP", "£", "Pound sterling");
    }
}
