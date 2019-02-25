namespace Pricing.Core.Models
{
    /// <summary>
    /// Represents the selling price for a tour departure
    /// </summary>
    public class TourDepartureSellingPrice
    {
        public TourDepartureSellingPrice(TourDeparture tourDeparture, Price sellingPrice)
        {
            TourDeparture = tourDeparture;
            SellingPrice = sellingPrice;
        }

        /// <summary>
        /// The tour departure
        /// </summary>
        public TourDeparture TourDeparture { get; }

        /// <summary>
        /// The selling price
        /// </summary>
        public Price SellingPrice { get; }
    }
}
