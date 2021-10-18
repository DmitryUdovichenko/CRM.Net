using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Stages table
    /// </summary>
    public class Stage
    {
        /// <summary>
        /// Id column
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title column
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description column
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Foreign key on project table
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// Project object
        /// </summary>
        public Project Project { get; set; }
        
        /// <summary>
        /// Persons on stage list
        /// </summary>
        public ICollection<PersonStage> PersonStages { get; set; }
    }
}
