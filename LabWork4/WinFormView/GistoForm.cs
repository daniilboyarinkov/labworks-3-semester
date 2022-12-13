using Model;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace WinFormView
{
    public partial class GistoForm : Form
    {
        public GistoForm(List<Student> students)
        {
            InitializeComponent();
            ShowGraph(students);
        }
        private void ShowGraph(List<Student> students)
        {
            GraphPane graphpane = zedGraphControl1.GraphPane;
            graphpane.CurveList.Clear();
            graphpane.Title.Text = "График распреления студентов по специальностям";
            graphpane.YAxis.Title.Text = "Количество студентов";

            var data = students.GroupBy(x => x.Speciality).Select(x => new { Speciality = x.Key, Count = x.Count() });

            string[] specialities = data.Select(x => x.Speciality).ToArray();
            double[] values = data.Select(x => (double)x.Count).ToArray();

            BarItem curve = graphpane.AddBar("Гистограмма", null, values, Color.Blue);

            graphpane.XAxis.Type = AxisType.Text;
            graphpane.XAxis.Scale.TextLabels = specialities.ToArray();

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
    
}
