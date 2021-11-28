using CRM.DA.EFContext;
using CRM.DA.Entities;
using CRM.DA.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Repositories
{
    /// <summary>
    /// Repository interface implementation typed with Profile
    /// </summary>
    public class ProfileRepository : BaseRepository<Profile>, IRepository<Profile>
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ProfileRepository(DBContext context):base(context)
        {
        }

    }
}
