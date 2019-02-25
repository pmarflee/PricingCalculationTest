using Pricing.Core.Models;
using System;

namespace Pricing.Core.Queries
{
    /// <summary>
    /// Query criteria for fetching a markup rate
    /// </summary>
    public class GetMarkupRateQuery : IQuery<MarkupRate>
    {
        public GetMarkupRateQuery(DateTime departureDate, Currency currency)
        {
            DepartureDate = departureDate;
            Currency = currency;
        }

        /// <summary>
        /// The date of departure
        /// </summary>
        public DateTime DepartureDate { get; }

        /// <summary>
        /// The currency 
        /// </summary>
        public Currency Currency { get; }
    }
}
