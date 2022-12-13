using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class, IDomainObject
    {
        IEnumerable<T> GetAll();
        void Create(T t);
        void DeleteById(int id);
        void Save();
    }
}
