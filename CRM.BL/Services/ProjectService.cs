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
    /// <summary>
    /// Project service
    /// </summary>
    public class ProjectService : IProjectService
    {
        /// <summary>
        /// Repository variable
        /// </summary>
        private IProjectRepository _repository;

        /// <summary>
        /// Mapper variable
        /// </summary>
        private IMapper _mapper;

        public ProjectService(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="project">Project transfer object</param>
        public void Create(ProjectDTO project)
        {
            var _project = _mapper.Map<Project>(project);
            _repository.Create(_project);
            _repository.Save();
        }

        // <summary>
        /// Delete project
        /// </summary>
        /// <param name="id">project id<param>
        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        /// <summary>
        /// Get project by id
        /// </summary>
        /// <param name="id">project id</param>
        /// <returns>Project transfer object</returns>
        public ProjectDTO Get(int id)
        {
            var project = _repository.Get(id);
            return _mapper.Map<ProjectDTO>(project);
        }

        /// <summary>
        /// Get all projects
        /// </summary>
        /// <returns>List of project transfer objects</returns>
        public IEnumerable<ProjectDTO> GetAll()
        {
            var projects =_repository.GetAll();
            return _mapper.Map<IEnumerable<ProjectDTO>>(projects);
        }

        /// <summary>
        /// Update Project data
        /// </summary>
        /// <param name="project">Project transfer object</param>
        public void Update(ProjectDTO project)
        {
            var _project = _mapper.Map<Project>(project);
            _repository.Update(_project);
            _repository.Save();
        }
    }
}
