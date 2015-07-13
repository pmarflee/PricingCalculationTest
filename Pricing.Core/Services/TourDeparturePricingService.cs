using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using System.Collections.Generic;

namespace Pricing.Core.Services
{
    public interface ITourDeparturePricingService
    {
        IEnumerable<TourDepartureSellingPrice> CalculatePrices(IEnumerable<TourDeparture> tourDepartures, Currency sellingCurrency);
    }
}
