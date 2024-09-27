using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheProject.Models;
using FontAwesome.Sharp;
using TheProject.Controls;
using TheProject.Views;

namespace TheProject.ViewModels
{
    public partial class VM_WContainer : ObservableObject
    {
        public M_WContainer model {  get; set; } = new M_WContainer();

        public V_Report report { get; set; } = new V_Report();

        [ObservableProperty]
        public string pagestate;

        [ObservableProperty]
        public IconChar pageicon;

        public _3DC sd { get; set; } = new _3DC();
        public ICommand changepages { get; }

        public ICommand bloqconfig { get; }

        public VM_WContainer()
        {
            model = new M_WContainer();

            Pagestate = model.PageView.ToString();
            Pageicon = model.Icon;
            changepages = new RelayCommand<ePageView>(changepage);
            bloqconfig = new RelayCommand<ePageView>(Configuration);
        }




        public void changepage(ePageView page)
        {
            switch (page)
            {
                case ePageView.DashBoard:
                    App.DashBoard.BB.Children.Clear();
                    App.main.item7.Children.Clear();
                    App.main.item7.Children.Add(App.DashBoard);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            

                    model.Icon = IconChar.Home;
                    model.PageView = ePageView.DashBoard;
                    //App.window2.item7.Children.Clear();
                    //App.window2.item7.Children.Add(App.dashboard);

                    break;

                case ePageView.Register:

                    model.Icon = IconChar.Wpforms;
                    model.PageView = ePageView.Register;
                    App.main.item7.Children.Clear();
                    App.main.item7.Children.Add(App.form); ;

                    break;

                case ePageView.ViewChamps:

                    model.Icon = IconChar.Usps;
                    model.PageView = ePageView.ViewChamps;
                    //App.window2.item7.Children.Clear();
              

                    break;
                case ePageView.Graphic:

                    model.Icon = IconChar.ChartLine;
                    model.PageView = ePageView.Graphic;
                    //App.window2.item7.Children.Clear();


                    break;

                case ePageView.Stats:

                    model.Icon = IconChar.BarChart;
                    model.PageView = ePageView.Stats;
                    //App.window2.item7.Children.Clear();


                    break;

                case ePageView.GenerateDocument:


                    model.Icon = IconChar.FileWaveform;
                    model.PageView = ePageView.GenerateDocument;
                    App.main.item7.Children.Clear();
                    App.main.item7.Children.Add(report);

                    break;

                case ePageView.Information:

                    model.Icon = IconChar.Info;
                    model.PageView = ePageView.Information;
                    //App.window2.item7.Children.Clear();


                    break;

                case ePageView.Config:

                    model.Icon = IconChar.Gear;
                    model.PageView = ePageView.Config;

                    if(App.main.B_Config.Visibility == System.Windows.Visibility.Visible)
                    {
                        App.main.B_Config.Visibility = System.Windows.Visibility.Collapsed;
                    }
                    else
                    {
                        App.main.B_Config.Visibility = System.Windows.Visibility.Visible;
                    }



                    break;
            }

        }

        private static void Configuration(ePageView page)
        {

            if (App.main.G_Gear.Visibility == System.Windows.Visibility.Visible)
            {
                App.main.G_Gear.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                App.main.G_Gear.Visibility = System.Windows.Visibility.Visible;
            }
           
            


        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}