using System;
using System.Collections.Generic;
using Model;

namespace SharedView
{
    public interface IView
    {
        void AddStudent(List<Student> students, Student student);
        event EventHandler<StudentArgs> EventStudentAddView;
        void DeleteStudent(List<Student> students);
        event EventHandler<StudentArgs> EventStudentDeleteView;
        void GetStudents(List<Student> students);
        event EventHandler<StudentArgs> EventStudentGetStudentsView;
    }
}
