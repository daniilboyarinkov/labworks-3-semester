using SharedView;
using Model;

namespace Presenter
{
    public class PresenterStudent
    {
        private readonly IView view = null;
        private readonly IModel model = null;

        public PresenterStudent(IView studentView, IModel studentModel)
        {
            view = studentView;
            view.EventStudentAddView += View_StudentAdd;
            view.EventStudentDeleteView += View_StudentDelete;
            view.EventStudentGetStudentsView += View_GetStudents;

            model = studentModel;
            model.EventStudentAddModel += Model_StudentAdd;
            model.EventStudentDeleteModel += Model_StudentDelete;
            model.EventStudentGetStudentsModel += Model_GetStudents;
        }

        // Add -------------------------------------------------
        public void View_StudentAdd(object sender, StudentArgs e)
            => model.AddStudent(e.Student);

        public void Model_StudentAdd(object sender, StudentArgs e)
            => view.AddStudent(e.Students, e.Student);

        // Delete -----------------------------------------------
        public void View_StudentDelete(object sender, StudentArgs e)
            => model.DeleteStudent(e.Student);

        public void Model_StudentDelete(object sender, StudentArgs e)
            => view.DeleteStudent(e.Students);

        // Get -------------------------------------------------
        public void View_GetStudents(object sender, StudentArgs e)
            => model.GetStudents();

        public void Model_GetStudents(object sender, StudentArgs e)
            => view.GetStudents(e.Students);
    }
}
