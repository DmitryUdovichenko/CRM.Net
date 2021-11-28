using CRM.DA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Interfaces
{
    /// <summary>
    /// Repository interface typed with Project
    /// </summary>
    public interface IProjectRepository :IRepository<Project>
    {
        Project GetFullProject(int id);
    }
}
