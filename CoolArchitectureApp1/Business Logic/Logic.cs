using Model;
using System.Collections.Generic;
using DataAccessLayer;

namespace Business_Logic
{
    public class Logic
    {
        // public List<Student> Students { get; set; } = new List<Student>();

        // IRepository<Student> repo = new EntityFrameworkRepository<Student>();
        IRepository<Student> repo = new DapperRepository<Student>();

        // Temp init method
        //public void InitStudents()
        //{
        //    Students = new List<Student>() {
        //    new Student() { Name="Иванов И. И.", Group="10", Speciality="ПИ" },
        //    new Student() { Name="Петров П. П.", Group="21", Speciality="ИСИТ" },
        //    new Student() { Name="Соболев И. В.", Group="10", Speciality="ИВТ" },
        //    new Student() { Name="Сергеев С. С.", Group="23", Speciality="ПИ" },
        //    new Student() { Name="Алексеев Э. С.", Group="10", Speciality="ИСИТ" },
        //    new Student() { Name="Васильев П. И.", Group="21", Speciality="ИВТ" },
        //    new Student() { Name="Морозин И. М.", Group="23", Speciality="ИВТ" },
        //    new Student() { Name="Сидоров С. П.", Group="21", Speciality="ИВТ" }
        //    };
        //}
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