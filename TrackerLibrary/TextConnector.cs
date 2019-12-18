namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make CreatePrize method save to text file
        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
