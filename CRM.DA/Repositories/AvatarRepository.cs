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
    public class AvatarRepository : IRepository<Avatar>
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DBContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public AvatarRepository(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creating Avatar
        /// </summary>
        /// <param name="item">Avatar Object</param>
        public void Create(Avatar item)
        {
            _context.Avatars.Add(item);
        }

        /// <summary>
        /// Deleting Avatar
        /// </summary>
        /// <param name="id">Avatar id</param>
        public void Delete(int id)
        {
            var Avatar = _context.Avatars.FirstOrDefault(x => x.Id == id);
            _context.Avatars.Remove(Avatar);
        }

        /// <summary>
        /// Avatar Searching 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of Avatar objects</returns>
        public IEnumerable<Avatar> Find(Func<Avatar, bool> predicate)
        {
            return _context.Avatars.Where(predicate).ToList();
        }

        /// <summary>
        /// Take avatar entity by id
        /// </summary>
        /// <param name="id">Avatar id</param>
        /// <returns>Avatar object</returns>
        public Avatar Get(int id)
        {
            return _context.Avatars.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Get all Avatars
        /// </summary>
        /// <returns>List of avatar objects</returns>
        public IEnumerable<Avatar> GetAll()
        {
            return _context.Avatars;
        }

        /// <summary>
        /// Updating Avatar entity
        /// </summary>
        /// <param name="item">Avatar object</param>
        public void Update(Avatar item)
        {
            _context.Avatars.Update(item);
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
