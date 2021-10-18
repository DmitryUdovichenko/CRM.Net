using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Profiles table
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Id column
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Profile file path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Foreign key on person table
        /// </summary>

        public int PersonId { get; set; }
    }
}
