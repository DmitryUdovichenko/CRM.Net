using AutoMapper;
using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.DA.Entities;
using CRM.DA.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Services
{
    /// <summary>
    /// Person service
    /// </summary>
    public class PersonService : IPersonService
    {
        /// <summary>
        /// Repository variable
        /// </summary>
        private IUnitOfWork _repository;

        /// <summary>
        /// Mapper variable
        /// </summary>
        private IMapper _mapper;


        public PersonService(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="person">Data transfer object</param>
        public void Create(PersonDTO person)
        {
            var _person = _mapper.Map<Person>(person);
            _repository.Persons.Create(_person);
            _repository.Save();
        }

        /// <summary>
        /// Delete person
        /// </summary>
        /// <param name="id">person id<param>
        public void Delete(int id)
        {
            var person = _repository.Persons.Get(id);
            _repository.Persons.Delete(person);
            _repository.Save();
        }

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">person id</param>
        /// <returns>Person transfer object</returns>
        public PersonDTO Get(int id)
        {
            var _person = _repository.Persons.Get(id);
            return _mapper.Map<PersonDTO>(_person);
        }

        /// <summary>
        /// Get all persons
        /// </summary>
        /// <returns>List of person transfer objects</returns
        public IEnumerable<PersonDTO> GetAll()
        {
            var _persons = _repository.Persons.GetAll();
            return _mapper.Map<IEnumerable<PersonDTO>>(_persons);
        }

        /// <summary>
        /// Update Person data
        /// </summary>
        /// <param name="person">Person transfer object</param>
        public void Update(PersonDTO person)
        {
            var _person = _mapper.Map<Person>(person);
            _repository.Persons.Update(_person);
            _repository.Save();
        }
    }
}
