using CRM.DA.EFContext;
using CRM.DA.Entities;
using CRM.DA.Interfaces;
using CRM.DA.Repositories;
using CRM.DA.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext _context;
        private ProjectRepository _projectRepository;
        private StageRepository _stageRepository;
        private PersonRepository _personRepository;

        public UnitOfWork(DBContext context)
        {
            this._context = context;
        }

        public IRepository<Person> Persons => _personRepository ??= new PersonRepository(_context);

        public IProjectRepository Projects => _projectRepository ??= new ProjectRepository(_context);

        public IRepository<Stage> Stages => _stageRepository ??= new StageRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
