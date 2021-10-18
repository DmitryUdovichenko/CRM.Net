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
    /// Repository interface implementation typed with Profile
    /// </summary>
    public class ProfileRepository : IRepository<Profile>
    {
        // <summary>
        /// Database context
        /// </summary>
        private readonly DBContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ProfileRepository(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creating Profile
        /// </summary>
        /// <param name="item">Profile Object</param>
        public void Create(Profile item)
        {
            _context.Profiles.Add(item);
        }

        /// <summary>
        /// Deleting profile
        /// </summary>
        /// <param name="id">Profile id</param>
        public void Delete(int id)
        {
            var Profile = _context.Profiles.FirstOrDefault(x => x.Id == id);
            _context.Profiles.Remove(Profile);
        }

        /// <summary>
        /// Profile Searching 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of profile objects</returns>
        public IEnumerable<Profile> Find(Func<Profile, bool> predicate)
        {
            return _context.Profiles.Where(predicate).ToList();
        }

        /// <summary>
        /// Take profile entity by id
        /// </summary>
        /// <param name="id">profile id</param>
        /// <returns>Profile object</returns>
        public Profile Get(int id)
        {
            return _context.Profiles.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Get all Profiles
        /// </summary>
        /// <returns>List of profile objects</returns>
        public IEnumerable<Profile> GetAll()
        {
            return _context.Profiles;
        }

        /// <summary>
        /// Updating Progile entity
        /// </summary>
        /// <param name="item">Profile object</param>
        public void Update(Profile item)
        {
            _context.Profiles.Update(item);
        }

        // <summary>
        /// Save context state
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
