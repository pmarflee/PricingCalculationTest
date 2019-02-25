using System;

namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents a tour departure
    /// </summary>
    public class TourDeparture
    {
        public TourDeparture(int id, string description, DateTime departureDate, Price localCost)
        {
            Id = id;
            Description = description;
            DepartureDate = departureDate;
            LocalCost = localCost;
        }

        /// <summary>
        /// Unique identifier for the tour departure
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Tour departure description
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Departure date 
        /// </summary>
        public DateTime DepartureDate { get; }

        /// <summary>
        /// Local cost
        /// </summary>
        public Price LocalCost { get; }
    }
}
