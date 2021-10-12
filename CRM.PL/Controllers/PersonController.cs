using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.DA.Entities;
using CRM.BL.Interfaces;
using AutoMapper;
using CRM.PL.Models;
using CRM.BL.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        IPersonService _personService;

        private IMapper _mapper;

        public PersonController(IPersonService service, IMapper mapper)
        {
            _personService = service;

            _mapper = mapper;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonViewModel> Get()
        {
            var _persons = _personService.GetAll();
            return _mapper.Map<IEnumerable<PersonViewModel>>(_persons);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public PersonViewModel Get(int id)
        {
            var _person = _personService.Get(id);
            return _mapper.Map<PersonViewModel>(_person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonViewModel person)
        {
            var _person = _mapper.Map<PersonDTO>(person);
            _personService.Create(_person);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonViewModel person)
        {
            var _person = _mapper.Map<PersonDTO>(person);
            _personService.Update(_person);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.Delete(id);
        }
    }
}
