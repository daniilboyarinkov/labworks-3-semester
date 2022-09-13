using Business_Logic;
using ZedGraph;

namespace WinFormsView
{
    public partial class MainWindow : Form
    {
        private readonly Logic BL = new();
        public MainWindow()
        {
            InitializeComponent();

            BL.InitStudents();

            UpdateStudentList();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // гисторгамма? nice
            DrawGraph(zedGraph);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Create String Validate Decorator
            string name = name_field.Text.Trim();
            string speciality = speciality_field.Text.Trim();
            string group = group_field.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя не может быть пустым...", "Name Alert!");
                return;
            }
            if (string.IsNullOrEmpty(speciality))
            {
                MessageBox.Show("Поле Специализация не может быть пустым...", "Speciality Alert!");
                return;
            }
            if (string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Поле Группа не может быть пустым...", "Group Alert!");
                return;
            }

            BL.AddStudent(name, speciality, group);
            // rerender? OMG hate it...
            UpdateStudentList();
            DrawGraph(zedGraph);

            // Не забывайте убирать за собой мусор
            ClearAddStudentFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.DeleteStudent(StudentBox.SelectedIndex);
            // rerender? OMG hate it...
            UpdateStudentList();
            DrawGraph(zedGraph);
        }

        private void UpdateStudentList()
        {
            StudentBox.DataSource = BL.Students
                .Select((st, index) => $"{index}.\t{st.Name}\t{st.Speciality}\t{st.Group}")
                .ToArray();
        }

        private void ClearAddStudentFields()
        {
            name_field.Text = string.Empty;
            speciality_field.Text = string.Empty;
            group_field.Text = string.Empty;
        }

        private List<SpecialityAnalitic> GetSpecialityStatistic() => BL.Students
                .Select(st => st.Speciality)
                .GroupBy(x => x)
                .Select(g => new SpecialityAnalitic() { Name = g.Key, Count = g.Count() })
                .ToList();
        
        private void DrawGraph(ZedGraphControl zedGraph)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();

            pane.YAxis.Title.Text = "Кол-во студентов";
            pane.XAxis.Title.Text = "Специальности";
            pane.YAxis.Scale.MinorStep = 1.0;
            pane.Title.Text = "Соотношение Специальность-Студенты";

            List<SpecialityAnalitic> Statistics = GetSpecialityStatistic();

            int itemscount = Statistics.Count;

            double[] XValues = new double[itemscount];
            double[] YValues1 = new double[itemscount];
            string[] Names = new string[itemscount];

            for (int i = 0; i < itemscount; i++)
            {
                XValues[i] = i + 1;
                YValues1[i] = Statistics[i].Count;
                Names[i] = Statistics[i].Name;
            }

            pane.AddBar("Специальности студентов", XValues, YValues1, Color.Blue);
            pane.XAxis.Type = AxisType.Text;
            pane.XAxis.Scale.TextLabels = Names;

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistic SF = new();
            SF.ShowDialog();
        }
    }
}
