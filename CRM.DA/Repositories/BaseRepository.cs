using CRM.DA.EFContext;
using CRM.DA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DBContext _context;

        public BaseRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
        }

        public void Delete(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }


        public void Update(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
        }
    }
}
