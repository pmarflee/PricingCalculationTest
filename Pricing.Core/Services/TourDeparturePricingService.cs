using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Core.Services
{
    public interface ITourDeparturePricingService
    {
        IEnumerable<TourDepartureSellingPrice> CalculatePrices(IEnumerable<TourDeparture> tourDepartures, Currency sellingCurrency);
    }
}
