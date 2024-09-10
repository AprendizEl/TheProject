using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WPF;
using Microsoft.VisualBasic;
using Microsoft.Xaml.Behaviors;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheProject.Controls
{
    /// <summary>
    /// Lógica de interacción para GrC.xaml
    /// </summary>
    public partial class GrC : System.Windows.Controls.UserControl
    {
        private IEnumerable<ISeries> _lineSeries;
        private Axis[] _xAxes;
        private Axis[] _yAxes;


        public GrC()
        {
            InitializeComponent();

            // Datos de ejemplo para las series
            SetupChart();
        }

        private void SetupChart()
        {
            var s = new List<string>();

            for (int i = 0; i < 30; i++)
            {


                s.Add($"{i}");
            }


            chart.Series = new ISeries[]
            {
               new LineSeries<double>
               {
                   Values = new double[] { 3, 4, 6, 5, 8, 9, 4, 6 },

               }
            };

            chart.XAxes = new Axis[]
            {
                new Axis
                {
                    Tag = "X Axis",
                    Labels = s.ToArray()
                }

            };

            chart.YAxes = new Axis[]
            {
                new Axis
                {
                    Tag = "Y Axis",
                    Labeler = value => value.ToString()
                }
            };


        }
    }
}