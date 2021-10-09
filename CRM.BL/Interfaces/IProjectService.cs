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
        void Create(ProjectDTO project);
        IEnumerable<ProjectDTO> GetAll();
        ProjectDTO Get(int id);
        void Update(ProjectDTO project);
        void Delete(int id);
    }
}
