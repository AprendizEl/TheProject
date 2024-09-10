using CommunityToolkit.Mvvm.Input;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheProject.Views;

namespace TheProject.ViewModels
{
    class VM_VLogin
    {

        public ICommand Start {  get;}

        public ICommand setuser { get; }


        public VM_VLogin()
        {

            Start = new RelayCommand(openpage);
            setuser = new RelayCommand(setu);

        }


        public void openpage()
        {


            App.main.Show();

            App.init.Close();



        }

        public void setu()
        {
            var s = new V_ContainerB();

            s.contentGrid.Children.Add(App.register);

            try
            {
                s.ShowDialog();
            }
            catch
            {

            }

         


        }


    }
}
