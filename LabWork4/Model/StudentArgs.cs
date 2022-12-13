using System;
using System.Collections.Generic;

namespace Model
{
    public class StudentArgs : EventArgs
    {
        public Student Student { get; set; }
        public List<Student> Students { get; set; }

        public StudentArgs() { }
        public StudentArgs(Student student) =>  Student = student;
        public StudentArgs(List<Student> students) => Students = students;
        public StudentArgs(List<Student> students, Student student)
        {
            Students = students;
            Student = student;
        }
    }
}
