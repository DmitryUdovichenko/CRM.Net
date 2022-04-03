using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    /// <summary>
    /// Stage service Interface
    /// </summary>
    public interface IStageService
    {
        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="stage">Data transfer object</param>
        void Create(StageDTO stage);

        /// <summary>
        /// Get stage by id
        /// </summary>
        /// <param name="id">Stage id</param>
        /// <returns>Stage transfer object</returns>
        StageDTO Get(int id);

        /// <summary>
        /// Get all stages of project
        /// </summary>
        /// <param name="id">Project id</param>
        /// <returns>List of stages</returns>
        IEnumerable<StageDTO> GetProjectStages(int id);

        /// <summary>
        /// Update stage
        /// </summary>
        /// <param name="stage">Stage transfer object</param>
        void Update(StageDTO stage);

        /// <summary>
        /// Delete stage
        /// </summary>
        /// <param name="id">Stage id</param>
        void Delete(int id);
    }
}
