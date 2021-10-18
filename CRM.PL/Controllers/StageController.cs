using AutoMapper;
using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : ControllerBase
    {
        private IStageService _stageService;
        private IMapper _mapper;

        public StageController(IStageService service, IMapper mapper)
        {
            _stageService = service;
            _mapper = mapper;
        }
        // GET: api/<StageController>
        /*[HttpGet("{id}")]
        public IEnumerable<StageViewModel> Get(int id)
        {
            var _stages = _stageService.GetProjectStages(id);
            return _mapper.Map<IEnumerable<StageViewModel>>(_stages);
        }

        // GET api/<StageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<StageController>
        [HttpPost]
        public void Post([FromBody] StageViewModel stage)
        {
            var _stage = _mapper.Map<StageDTO>(stage);
            _stageService.Create(_stage);
        }

        // PUT api/<StageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StageViewModel stage)
        {
            var _stage = _mapper.Map<StageDTO>(stage);
            _stageService.Update(_stage);
        }

        // DELETE api/<StageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _stageService.Delete(id);
        }
    }
}
