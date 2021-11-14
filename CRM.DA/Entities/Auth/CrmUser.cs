using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CRM.DA.Entities.Auth
{
    public class CrmUser : IdentityUser<Guid>
    {
        public CrmUserProfile CrmUserProfile { get; set; }
    }
}
