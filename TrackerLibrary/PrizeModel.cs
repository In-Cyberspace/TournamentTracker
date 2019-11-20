using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The place number associated with
        /// the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name associated with the
        /// PlaceNumber.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The cash prize associated with the
        /// PlaceNumber.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize associated
        /// with the PlaceNumber.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
