using CRM.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BL.Interfaces
{
    /// <summary>
    /// Person service Interface
    /// </summary>
    public interface IPersonService
    {
        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="person">Data transfer object</param>
        void Create(PersonDTO person);

        /// <summary>
        /// Get all persons
        /// </summary>
        /// <returns>List of person transfer objects</returns>
        IEnumerable<PersonDTO> GetAll();

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">person id</param>
        /// <returns>Person transfer object</returns>
        PersonDTO Get(int id);

        /// <summary>
        /// Update Person data
        /// </summary>
        /// <param name="person">Person transfer object</param>
        void Update(PersonDTO person);

        /// <summary>
        /// Delete person
        /// </summary>
        /// <param name="id">person id<param>
        void Delete(int id);
    }
}
