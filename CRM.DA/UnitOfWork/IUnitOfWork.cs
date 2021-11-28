using CRM.DA.Entities;
using CRM.DA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Person> Persons { get; }
        IProjectRepository Projects { get; }
        IRepository<Stage> Stages { get; }
        void Save();
    }
}
