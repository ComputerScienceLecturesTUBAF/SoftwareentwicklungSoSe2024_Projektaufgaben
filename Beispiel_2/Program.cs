using System;
using ScottPlot;

namespace PlotDiagrams
{
    class Program
    {
        static void Main(string[] args)
        {
          var plt = new ScottPlot.Plot(600, 400);

          // sample data
          double[] xs = DataGen.Consecutive(51);
          double[] sin = DataGen.Sin(51);
          double[] cos = DataGen.Cos(51);

          // plot the data
          plt.AddScatter(xs, sin);
          plt.AddScatter(xs, cos);

          // customize the axis labels
          plt.Title("ScottPlot Quickstart");
          plt.XLabel("Horizontal Axis");
          plt.YLabel("Vertical Axis");

          plt.SaveFig("quickstart_scatter.png");
        }
    }
}
