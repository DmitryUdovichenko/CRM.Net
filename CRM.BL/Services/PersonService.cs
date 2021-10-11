using AutoMapper;
using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.DA.Entities;
using CRM.DA.Interfaces;
using CRM.DA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repository;

        private IMapper _mapper;

        public PersonService(IPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(PersonDTO person)
        {
            var _person = _mapper.Map<Person>(person);
            _repository.Create(_person);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public PersonDTO Get(int id)
        {
            var _person = _repository.Get(id);
            return _mapper.Map<PersonDTO>(_person);
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            var _persons = _repository.GetAll();
            return _mapper.Map<IEnumerable<PersonDTO>>(_persons);
        }

        public void Update(PersonDTO person)
        {
            var _person = _mapper.Map<Person>(person);
            _repository.Update(_person);
            _repository.Save();
        }
    }
}
