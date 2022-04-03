using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Person Table
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Id Column
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
        /// Project creation date column
        /// </summary>
        public DateTime CreationDate { get; }

        /// <summary>
        /// Project expiration date column
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Project stages list
        /// </summary>
        public ICollection<Stage> Stages { get; set; }
    }
}
