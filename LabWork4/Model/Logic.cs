using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Logic : IModel
    {
        public List<Student> Students { get; set; } = new List<Student>()
        {
            new Student() { Name = "Андрей", Group = "КИ21-22Б", Speciality = "ПИ"},
            new Student() { Name = "Алексей", Group = "КИ21-12Б", Speciality = "ПИ"},
            new Student() { Name = "Артур", Group = "КИ21-21Б", Speciality = "ИСИТ"},
            new Student() { Name = "Абдурозик", Group = "ГИ21-20Б", Speciality = "ФИ"},
            new Student() { Name = "Артем", Group = "УБ21-02Б", Speciality = "ИСИТ"}
        };

        public event EventHandler<StudentArgs> EventStudentAddModel = delegate { };
        public event EventHandler<StudentArgs> EventStudentDeleteModel = delegate { };
        public event EventHandler<StudentArgs> EventStudentGetStudentsModel = delegate { };

        public void AddStudent(Student student)
        {
            Students.Add(student);
            EventStudentAddModel(this, new StudentArgs(Students, student));
        }
        public void DeleteStudent(Student student)
        {
            Students = Students.Where(st => st.Name != student.Name).ToList();
            EventStudentDeleteModel(this, new StudentArgs(Students));
        }
        public void GetStudents()
        {
            EventStudentGetStudentsModel(this, new StudentArgs(Students));
        }
    }
}
