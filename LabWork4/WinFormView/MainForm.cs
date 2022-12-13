using System.Collections.Generic;
using System.Windows.Forms;
using SharedView;
using Presenter;
using System;
using Model;
using static System.Windows.Forms.ListView;

namespace WinFormView
{
    public partial class MainForm : Form, IView
    {
        public event EventHandler<StudentArgs> EventStudentAddView = delegate { };
        public event EventHandler<StudentArgs> EventStudentDeleteView = delegate { };
        public event EventHandler<StudentArgs> EventStudentGetStudentsView = delegate { };

        private List<Student> Students = new List<Student>();

        private readonly IModel model = null;
        private readonly PresenterStudent presenter;

        public MainForm()
        {
            InitializeComponent();

            model = new Logic();
            presenter = new PresenterStudent(this, model);
            EventStudentGetStudentsView(this, new StudentArgs());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            StudentList.Clear();
            StudentList.View = View.Details;

            StudentList.Columns.Add("Имя", 150);
            StudentList.Columns.Add("Cпециальность", 150);
            StudentList.Columns.Add("Группа", 150);

            UpdateStudentList(Students);
        }

        // Interface implementation --------------------------------
        public void AddStudent(List<Student> students, Student student)
        {
            Students = students;
            UpdateStudentList(students);
        }

        public void DeleteStudent(List<Student> students)
        {
            Students = students;
            UpdateStudentList(students);
        }

        public void GetStudents(List<Student> students) =>
            Students = students;

        // Button Hadlers ------------------------------------------
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection row = StudentList.SelectedItems;

            if (row.Count == 0)
            {
                MessageBox.Show("Выбериту хоть что-нибудь. Ну серьезно...", "СТОП ЧТО ЭТО ТАКОЕ ТУТ");
                return;
            }

            string name = row[0].SubItems[0].Text;
            string speciality = row[0].SubItems[1].Text;
            string group = row[0].SubItems[2].Text;

            Student student = new Student()
            {
                Name = name,
                Speciality = speciality,
                Group = group
            };

            EventStudentDeleteView(this, new StudentArgs(student));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = StudentName.Text;
            string speciality = StudentSpeciality.Text;
            string group = StudentGroup.Text;

            if (string.IsNullOrEmpty(name) || 
                string.IsNullOrEmpty(speciality) || 
                string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Вы забыли ввести что-то.\nБольше не забывайте.\nНе за что.", "СТОП ЧТО ЭТО ТАКОЕ ТУТ");
                return;
            }

            Student student = new Student()
            {
                Name = name,
                Speciality = speciality,
                Group = group
            };

            EventStudentAddView(this, new StudentArgs(student));
        }

        private void ShowGistogrameButton_Click(object sender, EventArgs e)
        {
            GistoForm gistoForm = new GistoForm(Students);
            gistoForm.ShowDialog();
        }

        // Helpers -------------------------------------------------
        private void UpdateStudentList(List<Student> Students)
        {
            StudentList.Items.Clear();
            Students.ForEach(student =>
            {
                ListViewItem newitem = new ListViewItem(new string[] { student.Name, student.Speciality, student.Group });
                StudentList.Items.Add(newitem);
            });
        }
    }
}
