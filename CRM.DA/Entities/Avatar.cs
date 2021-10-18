using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Avatar model
    /// </summary>
    public class Avatar
    {
        /// <summary>
        /// id  column
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Path to file column
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Foreign kei on person table
        /// </summary>
        public int PersonId { get; set; }
    }
}
