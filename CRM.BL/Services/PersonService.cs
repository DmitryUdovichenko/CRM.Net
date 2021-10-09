using AutoMapper;
using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.DA.Entities;
using CRM.DA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Services
{
    class PersonService : IPersonService
    {
        private PersonRepository _repository;

        private IMapper _mapper;

        public PersonService(PersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(PersonDTO person)
        {
            var _stage = _mapper.Map<Person>(person);
            _repository.Create(_stage);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public PersonDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonDTO> GetStagePersons(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
