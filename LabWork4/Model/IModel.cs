using System;

namespace Model
{
    public interface IModel
    {
        void AddStudent(Student student);
        event EventHandler<StudentArgs> EventStudentAddModel;

        void DeleteStudent(Student student);
        event EventHandler<StudentArgs> EventStudentDeleteModel;

        void GetStudents();
        event EventHandler<StudentArgs> EventStudentGetStudentsModel;
    }
}
