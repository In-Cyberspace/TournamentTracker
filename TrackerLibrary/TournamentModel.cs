using System.Collections.Generic;
namespace TrackerLibrary
{
    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the name of the
        /// current tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the tournament's entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of the teams participating in the
        /// tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } =
            new List<TeamModel>();

        /// <summary>
        /// A list of the prizes awarded in the
        /// tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// A list of lists of matchups, each matchup
        /// list represents a round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } =
            new List<List<MatchupModel>>();
    }
}
