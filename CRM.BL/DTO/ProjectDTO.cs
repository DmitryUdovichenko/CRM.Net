using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.DTO
{
    /// <summary>
    /// Project Data Transfer Object
    /// </summary>
    public class ProjectDTO
    {
        /// <summary>
        /// Id parameter
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title parameter
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description parameter
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Creation date parameter
        /// </summary>
        public DateTime? CreationDate { get; }

        /// <summary>
        /// Expiration date parameter
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Stages List parameter
        /// </summary>
        public IEnumerable<StageDTO> Stages { get; set; }

    }
}
