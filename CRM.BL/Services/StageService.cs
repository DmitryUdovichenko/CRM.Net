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
    /// Stage service
    /// </summary>
    public class StageService : IStageService
    {
        /// <summary>
        /// Repository variable
        /// </summary>
        private IUnitOfWork _repository;

        /// <summary>
        /// Mapper variable
        /// </summary>
        private IMapper _mapper;

        public StageService(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="stage">Data transfer object</param>
        public void Create(StageDTO stage)
        {
            var _stage = _mapper.Map<Stage>(stage);
            _repository.Stages.Create(_stage);
            _repository.Save();
        }

        /// <summary>
        /// Delete stage
        /// </summary>
        /// <param name="id">Stage id</param>
        public void Delete(int id)
        {
            var stage = _repository.Stages.Get(id);
            _repository.Stages.Delete(stage);
            _repository.Save();
        }

        /// <summary>
        /// Get stage by id
        /// </summary>
        /// <param name="id">Stage id</param>
        /// <returns>Stage transfer object</returns>
        public StageDTO Get(int id)
        {
            var stage = _repository.Stages.Get(id);
            return _mapper.Map<StageDTO>(stage);
        }

        /// <summary>
        /// Get all stages of project
        /// </summary>
        /// <param name="id">Project id</param>
        /// <returns>List of stages</returns>
        public IEnumerable<StageDTO> GetProjectStages(int id)
        {
            var stages = _repository.Stages.GetAll().Where(i => i.Id == id);
            return _mapper.Map<IEnumerable<StageDTO>>(stages);
        }

        /// <summary>
        /// Update stage
        /// </summary>
        /// <param name="stage">Stage transfer object</param>
        public void Update(StageDTO stage)
        {
            var _stage = _mapper.Map<Stage>(stage);
            _repository.Stages.Update(_stage);
            _repository.Save();
        }
    }
}
