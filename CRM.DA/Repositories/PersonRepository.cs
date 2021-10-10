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
    public class PersonRepository : IPersonRepository
    {
        private readonly DBContext _context;
        public PersonRepository(DBContext context)
        {
            _context = context;
        }
        public void Create(Person item)
        {
            _context.Persons.Add(item);
        }

        public void Delete(int id)
        {
            var Person = _context.Persons.FirstOrDefault(x => x.Id == id);
            _context.Persons.Remove(Person);
        }

        public IEnumerable<Person> Find(Func<Person, bool> predicate)
        {
            return _context.Persons.Where(predicate).ToList();
        }

        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
        }

        
        public void Update(Person item)
        {
            _context.Persons.Update(item);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
