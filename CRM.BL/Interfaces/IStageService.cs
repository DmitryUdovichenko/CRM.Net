using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    public interface IStageService
    {
        void Create(StageDTO stage);
        StageDTO Get(int id);
        IEnumerable<StageDTO> GetProjectStages(int id);
        void Update(StageDTO stage);
        void Delete(int id);
    }
}
