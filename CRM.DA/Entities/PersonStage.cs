using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    /// <summary>
    /// Pivot tabel pesons stages
    /// </summary>
    public class PersonStage
    {
        /// <summary>
        /// Person id
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Person object
        /// </summary>
        public Person Person { get; set; }
        /// <summary>
        /// Stage Id
        /// </summary>
        public int StageId { get; set; }
        /// <summary>
        /// Stage object
        /// </summary>
        public Stage Stage { get; set; }

    }
}
