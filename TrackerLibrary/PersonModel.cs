using System;
namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the team member's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the team member's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the team member's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the team member's cellphone number.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
