using CRM.DA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Interfaces
{
    /// <summary>
    /// Repository interface typed with Person
    /// </summary>
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
