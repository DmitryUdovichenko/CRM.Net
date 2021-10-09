using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    interface IPersonService
    {
        void Create(PersonDTO person);
        IEnumerable<PersonDTO> GetAll();
        PersonDTO Get(int id);
        IEnumerable<PersonDTO> GetStagePersons(int id);
        void Update(PersonDTO person);
        void Delete(int id);
    }
}
