using ZedGraph;

namespace WinFormsView
{
    // здесь должна быть вынесенная логика работы между окнами. но ее тут нет...  
    public static class LocalLogic
    {
        //public static void DrawGraph(ZedGraphControl zedGraph)
        //{
        //    GraphPane pane = zedGraph.GraphPane;

        //    pane.CurveList.Clear();

        //    pane.YAxis.Title.Text = "Кол-во студентов";
        //    pane.XAxis.Title.Text = "Специальности";
        //    pane.YAxis.Scale.MinorStep = 1.0;
        //    pane.Title.Text = "Соотношение Специальность-Студенты";

        //    List<SpecialityAnalitic> Statistics = GetSpecialityStatistic();

        //    int itemscount = Statistics.Count;

        //    double[] XValues = new double[itemscount];
        //    double[] YValues1 = new double[itemscount];
        //    string[] Names = new string[itemscount];

        //    for (int i = 0; i < itemscount; i++)
        //    {
        //        XValues[i] = i + 1;
        //        YValues1[i] = Statistics[i].Count;
        //        Names[i] = Statistics[i].Name;
        //    }

        //    pane.AddBar("Специальности студентов", XValues, YValues1, Color.Blue);
        //    pane.XAxis.Type = AxisType.Text;
        //    pane.XAxis.Scale.TextLabels = Names;

        //    zedGraph.AxisChange();
        //    zedGraph.Invalidate();
        //}
    }
}
