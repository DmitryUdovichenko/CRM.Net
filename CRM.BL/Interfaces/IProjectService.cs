using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    /// <summary>
    /// Project service Interface
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="project">Project transfer object</param>
        void Create(ProjectDTO project);

        /// <summary>
        /// Get all projects
        /// </summary>
        /// <returns>List of project transfer objects</returns>
        IEnumerable<ProjectDTO> GetAll();

        /// <summary>
        /// Get project by id
        /// </summary>
        /// <param name="id">project id</param>
        /// <returns>Project transfer object</returns>
        ProjectDTO Get(int id);

        /// <summary>
        /// Update Project data
        /// </summary>
        /// <param name="project">Project transfer object</param>
        void Update(ProjectDTO project);

        /// <summary>
        /// Delete project
        /// </summary>
        /// <param name="id">project id<param>
        void Delete(int id);
    }
}
