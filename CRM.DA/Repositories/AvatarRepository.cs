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
    /// Repository interface implementation typed with Avatar
    /// </summary>
    public class AvatarRepository : BaseRepository<Avatar>, IRepository<Avatar>
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public AvatarRepository(DBContext context) : base(context)
        {

        }

    }
}
