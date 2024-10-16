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

            Charts.Series = Series;

        }

        public ISeries[] Series { get; set; } =
{
    new LineSeries<Point>
    {
        Values = new List<Point>
        {
            new Point(10, 20),
            new Point(30, 40),
            new Point(50, 60)
        },
        GeometrySize = 1,
        LineSmoothness = 0, // 0 para una línea sin suavizado
        Stroke = new SolidColorPaint(SKColors.Red), // Color rojo
        // Grosor de la línea
    }
};

    }
}


