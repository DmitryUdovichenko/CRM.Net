using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.DTO
{
    /// <summary>
    /// Stage Data Transfer Object
    /// </summary>
    public class StageDTO
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
        /// Project Id parameter
        /// </summary>
        public int ProjectId { get; set; }
    }
}
