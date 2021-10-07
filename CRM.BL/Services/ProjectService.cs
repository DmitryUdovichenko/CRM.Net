using CRM.BL.DTO;
using CRM.BL.Interfaces;
using CRM.DA.Context;
using CRM.DA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Services
{
    class ProjectService : IProjectService
    {
        private DBContext _context;

        public ProjectService(DBContext context)
        {
            _context = context;
        }
        public void CreateProject(ProjectDTO projectDTO)
        {
            Project project = new Project
            {
                Title = projectDTO.Title,
                Description = projectDTO.Description,
                ExpirationDate = (DateTime)projectDTO.ExpirationDate
            };
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public IEnumerable<StageDTO> GetStages(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
