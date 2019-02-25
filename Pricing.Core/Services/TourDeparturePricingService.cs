using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;

namespace Pricing.Core.Services
{
    /// <summary>
    /// Calculates tour departure prices
    /// </summary>
    public class TourDeparturePricingService
    {
        private readonly IQueryHandler<GetExchangeRateQuery, ExchangeRate> _getExchangeRateQueryHandler;
        private readonly IQueryHandler<GetMarkupRateQuery, MarkupRate> _getMarkupRateQueryHandler;

        public TourDeparturePricingService(
            IQueryHandler<GetExchangeRateQuery, ExchangeRate> getExchangeRateQueryHandler,
            IQueryHandler<GetMarkupRateQuery, MarkupRate> getMarkupRateQueryHandler)
        {
            _getExchangeRateQueryHandler = getExchangeRateQueryHandler;
            _getMarkupRateQueryHandler = getMarkupRateQueryHandler;
        }

        /// <summary>
        /// Calculates the selling price for a tour departure
        /// </summary>
        /// <param name="tourDeparture">The tour departure to calculate the selling price for</param>
        /// <param name="sellingCurrency">The selling currency that the price should be calculated in</param>
        /// <returns>The selling price for the tour departure</returns>
        public TourDepartureSellingPrice CalculatePrice(TourDeparture tourDeparture, Currency sellingCurrency)
        {
            // TODO: If selling currency is different to local currency, convert price to selling currency

            // TODO: Mark up the price in the selling currency using the applicable markup rate

            // TODO: Return details of the marked up price for the tour departure in the selling currency

            throw new System.NotImplementedException();
        }
    }
}
