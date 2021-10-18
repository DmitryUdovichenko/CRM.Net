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
    /// Repository interface implementation typed with Avatar
    /// </summary>
    public class StageRepository : IStageRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DBContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public StageRepository(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Stage Avatar
        /// </summary>
        /// <param name="item">Stage Object</param>
        public void Create(Stage item)
        {
            _context.Stages.Add(item);
        }

        /// <summary>
        /// Deleting Stage
        /// </summary>
        /// <param name="id">Stage id</param>
        public void Delete(int id)
        {
            var Stage = _context.Stages.FirstOrDefault(x => x.Id == id);
            _context.Stages.Remove(Stage);
        }

        /// <summary>
        /// Stage Searching 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of Stage objects</returns>
        public IEnumerable<Stage> Find(Func<Stage, bool> predicate)
        {
            return _context.Stages.Include(o => o.PersonStages).Where(predicate).ToList();
        }

        /// <summary>
        /// Take Stage entity by id
        /// </summary>
        /// <param name="id">Stage id</param>
        /// <returns>Stage object</returns>
        public Stage Get(int id)
        {
            return _context.Stages.Include(o => o.PersonStages).FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Get all Stages
        /// </summary>
        /// <returns>List of Stage objects</returns>
        public IEnumerable<Stage> GetAll()
        {
            return _context.Stages;
        }

        /// <summary>
        /// Updating Stage entity
        /// </summary>
        /// <param name="item">Stage object</param>
        public void Update(Stage item)
        {
            _context.Stages.Update(item);
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
