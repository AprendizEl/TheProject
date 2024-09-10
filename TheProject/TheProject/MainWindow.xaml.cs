using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheProject.ViewModels;
using TheProject.Views;

namespace TheProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ResourceDictionary newthemeD = new ResourceDictionary();

        public ResourceDictionary newthemeL = new ResourceDictionary();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VM_WContainer();

            newthemeD = new ResourceDictionary
            {
                Source = new Uri("Styles/DarkTheme.xaml", UriKind.Relative) // Cargar el nuevo diccionario
            };

            newthemeL = new ResourceDictionary
            {
                Source = new Uri("Styles/LightTheme.xaml", UriKind.Relative) // Cargar el nuevo diccionario
            };
        }



        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var resourceDictionaries = Application.Current.Resources.MergedDictionaries;

            if (resourceDictionaries[0].Source.ToString().EndsWith("Colors.xaml"))
            {

                resourceDictionaries[0] = newthemeD;


            }
            else if (resourceDictionaries[0].Source.ToString().EndsWith("DarkTheme.xaml"))
            {
                resourceDictionaries[0] = newthemeL;
            }
            else
            {
                resourceDictionaries[0] = newthemeD;

            }          
           

            App.main.item7.UpdateLayout();
        }




        //private void SlideLeft_Click(object sender, RoutedEventArgs e)
        //{
        //    var storyboard = (Storyboard)FindResource("SlideLeft");
        //    storyboard.Begin(MainContent);

        //    var w = new V_ContainerB();
        //    w.Show();
        //}

        //private void SlideRight_Click(object sender, RoutedEventArgs e)
        //{
        //    var storyboard = (Storyboard)FindResource("SlideRight");
        //    storyboard.Begin(MainContent);
        //}

        //private void SlideUp_Click(object sender, RoutedEventArgs e)
        //{
        //    var storyboard = (Storyboard)FindResource("SlideUp");
        //    storyboard.Begin(MainContent);
        //}

        //private void SlideDown_Click(object sender, RoutedEventArgs e)
        //{
        //    var storyboard = (Storyboard)FindResource("SlideDown");
        //    storyboard.Begin(MainContent);
        //}
    }
}