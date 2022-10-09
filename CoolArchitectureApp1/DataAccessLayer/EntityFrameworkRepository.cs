using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        public void Create(T t)
        {
            context.Set<T>().Add(t);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void DeleteById(int id)
        {
            Student t = context.Students.Where(s => s.Id == id).FirstOrDefault();

            context.Set<Student>().Remove(t);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
