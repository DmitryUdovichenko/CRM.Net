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
    /// Repository interface implementation typed with Projec
    /// </summary>
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(DBContext context):base(context)
        {

        }
        private DBContext ProjectContext
        {
            get { return _context as DBContext; }
        }
        public Project GetFullProject(int id)
        {
            return ProjectContext.Projects.Include(s=>s.Stages).SingleOrDefault(i => i.Id == id);
        }

        public void ApplyPatch(Project project, Dictionary<string, object> properties)
        {
            var dbEntityEntry = _context.Entry(project);
            dbEntityEntry.CurrentValues.SetValues(properties);
            dbEntityEntry.State = EntityState.Modified;
        }

    }
}
