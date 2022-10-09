using Business_Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsView;
using ZedGraph;

namespace WinFormView
{
    public partial class Form1 : Form
    {
        private readonly Logic BL = new Logic();
        public Form1()
        {
            InitializeComponent();

            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            StudentBox.DataSource = BL.GetAll()
                .Select((st) => $"{st.Id}.\t{st.Name}\t{st.Speciality}\t{st.Group}")
                .ToArray();
        }

        private void ClearAddStudentFields()
        {
            name_field.Text = string.Empty;
            speciality_field.Text = string.Empty;
            group_field.Text = string.Empty;
        }

        private List<SpecialityAnalitic> GetSpecialityStatistic() => BL.GetAll()
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


        private void delbtn_Click_1(object sender, EventArgs e)
        {
            if (BL.GetAll().Count() > 0)
            {
                int id = Int32.Parse(StudentBox.SelectedItem.ToString().Split('.')[0]);
                BL.DeleteStudent(id);
            }
            // rerender? OMG hate it...
            UpdateStudentList();
            DrawGraph(zedGraph);
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
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

        private void statisticbtn_Click_1(object sender, EventArgs e)
        {
            Statistic SF = new Statistic();
            // SF.Show();
            SF.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // гисторгамма? nice
            DrawGraph(zedGraph);
        }
    }
}
