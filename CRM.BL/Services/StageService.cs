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
    class StageService : IStageService
    {
        private StageRepository _repository;

        private IMapper _mapper;

        public StageService(StageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(StageDTO stage)
        {
            var _stage = _mapper.Map<Stage>(stage);
            _repository.Create(_stage);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public StageDTO Get(int id)
        {
            var stage = _repository.Get(id);
            return _mapper.Map<StageDTO>(stage);
        }


        public IEnumerable<StageDTO> GetProjectStages(int id)
        {
            var stages = _repository.GetAll().Where(i => i.Id == id);
            return _mapper.Map<IEnumerable<StageDTO>>(stages);
        }

        public void Update(StageDTO stage)
        {
            var _stage = _mapper.Map<Stage>(stage);
            _repository.Update(_stage);
            _repository.Save();
        }
    }
}
