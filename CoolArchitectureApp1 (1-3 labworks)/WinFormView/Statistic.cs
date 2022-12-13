using Business_Logic;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using ZedGraph;
using Ninject;

namespace WinFormsView
{
    public partial class Statistic : Form
    {
        private System.ComponentModel.IContainer components;
        private ZedGraphControl zedGraph;
        private static readonly IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
        private static readonly Logic BL = ninjectKernel.Get<Logic>();
        private void Statistic_Load_1(object sender, EventArgs e)
        {
            DrawGraph(zedGraph);
        }

        public Statistic()
        {
            InitializeComponent();
            DrawGraph(zedGraph);
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(15, 15);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(664, 470);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // Statistic
            // 
            this.ClientSize = new System.Drawing.Size(699, 505);
            this.Controls.Add(this.zedGraph);
            this.Name = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load_1);
            this.ResumeLayout(false);

        }
    }
}