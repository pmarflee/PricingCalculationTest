using Pricing.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Queries
{
    public class GetCurrencyQuery : IQuery<Currency>
    {
        public string Code { get; set; }
    }
}
