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
    public class ProfileRepository : IRepository<Profile>
    {
        private readonly DBContext _context;
        public ProfileRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(Profile item)
        {
            _context.Profiles.Add(item);
        }

        public void Delete(int id)
        {
            var Profile = _context.Profiles.FirstOrDefault(x => x.Id == id);
            _context.Profiles.Remove(Profile);
        }

        public IEnumerable<Profile> Find(Func<Profile, bool> predicate)
        {
            return _context.Profiles.Where(predicate).ToList();
        }

        public Profile Get(int id)
        {
            return _context.Profiles.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Profile> GetAll()
        {
            return _context.Profiles;
        }

        public void Update(Profile item)
        {
            _context.Profiles.Update(item);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
