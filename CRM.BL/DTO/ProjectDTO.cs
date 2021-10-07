using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.DTO
{
    public class ProjectDTO
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? CreationDate { get; }

        public DateTime? ExpirationDate { get; set; }

    }
}
