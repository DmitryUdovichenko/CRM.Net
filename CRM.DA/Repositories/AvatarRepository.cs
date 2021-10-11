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
    public class AvatarRepository : IRepository<Avatar>
    {
        private readonly DBContext _context;
        public AvatarRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(Avatar item)
        {
            _context.Avatars.Add(item);
        }

        public void Delete(int id)
        {
            var Avatar = _context.Avatars.FirstOrDefault(x => x.Id == id);
            _context.Avatars.Remove(Avatar);
        }

        public IEnumerable<Avatar> Find(Func<Avatar, bool> predicate)
        {
            return _context.Avatars.Where(predicate).ToList();
        }

        public Avatar Get(int id)
        {
            return _context.Avatars.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Avatar> GetAll()
        {
            return _context.Avatars;
        }

        public void Update(Avatar item)
        {
            _context.Avatars.Update(item);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
