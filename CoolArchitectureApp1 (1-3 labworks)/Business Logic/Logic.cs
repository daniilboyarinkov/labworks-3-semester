using Model;
using System.Collections.Generic;
using DataAccessLayer;

namespace Business_Logic
{
    public class Logic
    {
        readonly IRepository<Student> repo;

        public Logic(IRepository<Student> repository)
        {
            this.repo = repository;
        }
        public void AddStudent(string name, string speciality, string group)
        {
            Student student = new Student()
            {
                Name = name,
                Speciality = speciality,
                Group = group
            };
            repo.Create(student);
            repo.Save();
        }
        public IEnumerable<Student> GetAll()
        {
            return repo.GetAll();
        }
        public void DeleteStudent(int index)
        {
            repo.DeleteById(index);
            repo.Save();
        }
    }
}