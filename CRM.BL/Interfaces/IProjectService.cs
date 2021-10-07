using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    interface IProjectService
    {
        void CreateProject(ProjectDTO projectDTO);
        IEnumerable<StageDTO> GetStages(int Id);

    }
}
