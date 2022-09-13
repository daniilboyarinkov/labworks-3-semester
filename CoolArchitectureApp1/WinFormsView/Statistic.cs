using Business_Logic;
using ZedGraph;

namespace WinFormsView
{
    public partial class Statistic : Form
    {
        private readonly Logic BL = new();

        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            BL.InitStudents();

            DrawGraph(zedGraph);
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
    }
}
