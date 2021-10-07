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
    public class ProjectRepository : IRepository<Project>
    {
        private readonly DBContext _context;
        public ProjectRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(Project item)
        {
            _context.Projects.Add(item);
        }

        public void Delete(int id)
        {
            var Project = _context.Projects.FirstOrDefault(x => x.Id == id);
            _context.Projects.Remove(Project);
        }

        public IEnumerable<Project> Find(Func<Project, bool> predicate)
        {
            return _context.Projects.Include(o => o.Stages).Where(predicate).ToList();
        }

        public Project Get(int id)
        {
            return _context.Projects.Include(o => o.Stages).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects;
        }

        public void Update(Project item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
