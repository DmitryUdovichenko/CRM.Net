using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Interfaces
{
    /// <summary>
    /// Repository interface
    /// </summary>
    /// <typeparam name="T">Should be one of entity</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Take all entities
        /// </summary>
        /// <returns>List of objects of T</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Return one entity
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <returns>Object of entity</returns>
        T Get(int id);

        /// <summary>
        /// Searching entity
        /// </summary>
        /// <param name="predicate">Expreshion</param>
        /// <returns>Object</returns>
        IEnumerable<T> Find(Func<T, Boolean> predicate);

        /// <summary>
        /// Creating entity
        /// </summary>
        /// <param name="item">object of T</param>
        void Create(T item);

        /// <summary>
        /// Updating entity
        /// </summary>
        /// <param name="item">object of T</param>
        void Update(T item);
        
        /// <summary>
        /// Deleting entyti
        /// </summary>
        /// <param name="id">id of entyti</param>
        void Delete(int id);

        /// <summary>
        /// Save state
        /// </summary>
        void Save();
    }
}
