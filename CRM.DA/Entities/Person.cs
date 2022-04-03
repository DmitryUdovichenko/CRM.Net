using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Person mode
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id column
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First Name column
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name column
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Phone column
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Email column
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Birth Date column
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Profession column
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// Foreign key on avatar table
        /// </summary>
        public int AvatarId { get; set; }
        /// <summary>
        /// Avatar object
        /// </summary>
        public Avatar Avatar { get; set; }
        /// <summary>
        /// Foreign key on profile table
        /// </summary>
        public int ProfileId { get; set; }
        /// <summary>
        /// Profile object
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Pivot table for stages
        /// </summary>
        public ICollection<PersonStage> PersonStages { get; set; }
    }
}
