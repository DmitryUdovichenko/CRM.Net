using CRM.DA.Context;
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
    public class ProjectRepository : IProjectRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DBContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creating Project
        /// </summary>
        /// <param name="item">Project Object</param>
        public void Create(Project item)
        {
            _context.Projects.Add(item);
        }

        /// <summary>
        /// Deleting Project
        /// </summary>
        /// <param name="id">Project id</param>
        public void Delete(int id)
        {
            var Project = _context.Projects.FirstOrDefault(x => x.Id == id);
            _context.Projects.Remove(Project);
        }

        /// <summary>
        /// Project Searching 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of Project objects</returns>
        public IEnumerable<Project> Find(Func<Project, bool> predicate)
        {
            return _context.Projects.Include(o => o.Stages).Where(predicate).ToList();
        }

        /// <summary>
        /// Take Project entity by id
        /// </summary>
        /// <param name="id">Project id</param>
        /// <returns>Project object</returns>
        public Project Get(int id)
        {
            return _context.Projects.Include(o => o.Stages).FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Get all Projects
        /// </summary>
        /// <returns>List of Project objects</returns>
        public IEnumerable<Project> GetAll()
        {
            return _context.Projects;
        }

        /// <summary>
        /// Updating Project entity
        /// </summary>
        /// <param name="item">Project object</param>
        public void Update(Project item)
        {
            _context.Projects.Update(item);
        }

        /// <summary>
        /// Save context state
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
