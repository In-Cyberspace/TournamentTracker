using System.Collections.Generic;
namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// A list of matchup entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } =
            new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the team that won the
        /// matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round number associated with
        /// the matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
