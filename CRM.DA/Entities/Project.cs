using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; }

        public DateTime ExpirationDate { get; set; }

        public ICollection<Stage> Stages { get; set; }
    }
}
