using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.DTO
{
    /// <summary>
    /// Person Data Transfer Object
    /// </summary>
    public class PersonDTO
    {
        /// <summary>
        /// Id parameter
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First Name parameter
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name parameter
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Phone parameter
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email parameter
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Birth Date parameter
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Profession parameter
        /// </summary>
        public string Profession { get; set; }


        /// <summary>
        /// Avatar parameter
        /// </summary>
        public int AvatarId { get; set; }

        /// <summary>
        ///  Profile parameter
        /// </summary>
        public int ProfileId { get; set; }
    }
}
