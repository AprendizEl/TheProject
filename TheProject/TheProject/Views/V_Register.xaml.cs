using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheProject.ViewModels;
using LiveChartsCore.SkiaSharpView.WPF;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel.Sketches;

namespace TheProject.Views
{
    /// <summary>
    /// Lógica de interacción para V_Register.xaml
    /// </summary>
    public partial class V_Register : UserControl
    {
        public V_Register()
        {
            InitializeComponent();
            VM_VRegister vm = new VM_VRegister();
            DataContext = vm;

            Charts.Series = Series2;
        }


        public ISeries[] Series2 { get; set; } =
        {
            new LineSeries<ObservablePoint>
            {
                Values = new List<ObservablePoint>
                {
                    new ObservablePoint(30, 20),
                    new ObservablePoint(20, 40),
                    new ObservablePoint(50, 60)
                },
                GeometrySize = 5,
                Stroke = new SolidColorPaint(SKColors.Red),
                LineSmoothness = 0 // 0 para línea sin suavizado
            }
        };


   

    }



    public class DataPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public DataPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}


