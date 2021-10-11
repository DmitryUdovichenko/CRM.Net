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
    public class ProjectService : IProjectService
    {
        private IProjectRepository _repository;

        private IMapper _mapper;

        public ProjectService(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(ProjectDTO project)
        {
            var _project = _mapper.Map<Project>(project);
            _repository.Create(_project);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public ProjectDTO Get(int id)
        {
            var project = _repository.Get(id);
            return _mapper.Map<ProjectDTO>(project);
        }

        public IEnumerable<ProjectDTO> GetAll()
        {
            var projects =_repository.GetAll();
            return _mapper.Map<IEnumerable<ProjectDTO>>(projects);
        }

        public void Update(ProjectDTO project)
        {
            var _project = _mapper.Map<Project>(project);
            _repository.Update(_project);
            _repository.Save();
        }
    }
}
