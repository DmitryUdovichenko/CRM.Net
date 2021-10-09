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
    public class StageRepository : IRepository<Stage>
    {
        private readonly DBContext _context;
        public StageRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(Stage item)
        {
            _context.Stages.Add(item);
        }

        public void Delete(int id)
        {
            var Stage = _context.Stages.FirstOrDefault(x => x.Id == id);
            _context.Stages.Remove(Stage);
        }

        public IEnumerable<Stage> Find(Func<Stage, bool> predicate)
        {
            return _context.Stages.Include(o => o.PersonStages).Where(predicate).ToList();
        }

        public Stage Get(int id)
        {
            return _context.Stages.Include(o => o.PersonStages).FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Stage> GetAll()
        {
            return _context.Stages;
        }

        public void Update(Stage item)
        {
            _context.Stages.Update(item);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
