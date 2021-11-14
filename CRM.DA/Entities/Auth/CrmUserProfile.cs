using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities.Auth
{
    public class CrmUserProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public Guid CrmUserId { get; set; }
        public CrmUser CrmUser { get; set; }

    }
}
