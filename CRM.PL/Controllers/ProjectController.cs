using AutoMapper;
using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.DA.Entities;
using CRM.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM.PL.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;
        private IMapper _mapper;

        public ProjectController(IProjectService service, IMapper mapper)
        {
            _projectService = service;

            _mapper = mapper;
        }
        // GET: api/<ProjectController>
        [HttpGet]
        public IEnumerable<ProjectViewModel> Get()
        {
            var _projects = _projectService.GetAll();
            return _mapper.Map<IEnumerable<ProjectViewModel>>(_projects);
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public ProjectViewModel Get(int id)
        {
            var _project = _projectService.Get(id);
            return _mapper.Map<ProjectViewModel>(_project);
        }

        // POST api/<ProjectController>
        [HttpPost]
        public void Post([FromBody] ProjectViewModel project)
        {
            var _project = _mapper.Map<ProjectDTO>(project);
            _projectService.Create(_project);
        }

        [HttpPost("deafult/{count}")]
        public void PostDefault(int count, [FromBody] ProjectViewModel project)
        {
            var _project = _mapper.Map<ProjectDTO>(project);
            _projectService.CreateDefault(_project,count);
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProjectViewModel project)
        {
            var _project = _mapper.Map<ProjectDTO>(project);
            _projectService.Update(_project);
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _projectService.Delete(id);
        }


        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] JsonPatchDocument<Project> patch)
        {
            _projectService.PartialUpdate(id, patch);
        }
    }
}
