using Pricing.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Queries
{
    public class GetMarkupRateQuery : IQuery<MarkupRate>
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Currency Currency { get; set; }
    }
}
