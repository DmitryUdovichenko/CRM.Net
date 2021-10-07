using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    public class PersonStage
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int StageId { get; set; }
        public Stage Stage { get; set; }

    }
}
