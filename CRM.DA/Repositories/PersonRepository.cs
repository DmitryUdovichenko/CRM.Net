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
    /// Repository interface implementation typed with Person
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DBContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public PersonRepository(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creating Person
        /// </summary>
        /// <param name="item">Person Object</param>
        public void Create(Person item)
        {
            _context.Persons.Add(item);
        }

        /// <summary>
        /// Deleting Person
        /// </summary>
        /// <param name="id">Person id</param>
        public void Delete(int id)
        {
            var Person = _context.Persons.FirstOrDefault(x => x.Id == id);
            _context.Persons.Remove(Person);
        }

        /// <summary>
        /// Person Searching 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of Person objects</returns>
        public IEnumerable<Person> Find(Func<Person, bool> predicate)
        {
            return _context.Persons.Where(predicate).ToList();
        }

        /// <summary>
        /// Take person entity by id
        /// </summary>
        /// <param name="id">Person id</param>
        /// <returns>Person object</returns>
        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Get all Persons
        /// </summary>
        /// <returns>List of person objects</returns>
        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
        }

        // <summary>
        /// Updating Person entity
        /// </summary>
        /// <param name="item">Person object</param>
        public void Update(Person item)
        {
            _context.Persons.Update(item);
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
