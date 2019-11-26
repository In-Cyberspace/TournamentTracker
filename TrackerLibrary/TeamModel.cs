using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// A list of the members in this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } =
            new List<PersonModel>();

        /// <summary>
        /// Represents the name this team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
