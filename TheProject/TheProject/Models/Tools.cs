using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

using System.Threading.Tasks;
using LiveChartsCore;
using System.Windows.Forms;

namespace TheProject.Models
{
    public class Tools
    {
        public void SaveToBinaryFile<T>(List<T> data, string filePath)
        {
            var serializer = new DataContractSerializer(typeof(List<T>));
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                serializer.WriteObject(stream, data);
            }
        }

        public List<T> LoadFromBinaryFile<T>(string filePath)
        {
            var serializer = new DataContractSerializer(typeof(List<T>));
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return (List<T>)serializer.ReadObject(stream);
            }
        }





    }


    public partial class Datos_DiseñoAFlexion : ObservableObject
    {

        [ObservableProperty]
        private int d;

        [ObservableProperty]
        private int d2;

        [ObservableProperty]
        private int b;

        [ObservableProperty]
        private int fc;

        [ObservableProperty]
        private int fy;

        [ObservableProperty]
        private int mu;

        [ObservableProperty]
        private bool vigas;

        [ObservableProperty]
        private bool vigans;

        public Datos_DiseñoAFlexion()
        {
            D = 35;
            B = 30;
            D2 = 5;
            Fc = 210;
            Fy = 4220;
            Mu = 1;
            Vigas = false;
            Vigans = false;
        }

    }



    public partial class Datos_Cortante : ObservableObject
    {

        [ObservableProperty]
        private float d;

        [ObservableProperty]
        private float d2;

        [ObservableProperty]
        private float r;

        [ObservableProperty]
        private float b;

        [ObservableProperty]
        private float fc;

        [ObservableProperty]
        private float fy;

        [ObservableProperty]
        private float vu;

        [ObservableProperty]
        private float t;

        [ObservableProperty]
        private int ramas;

        [ObservableProperty]
        private int barra;

        [ObservableProperty]
        private bool vigah;

        [ObservableProperty]
        private bool vigaa;


        public Datos_Cortante()
        {
            D = 55;
            D2 = 5;
            R = 5;
            B = 30;
            Fc = 210;
            Fy = 4220;
            Vu = 8.7f;
            T = 1.386f;
            Ramas = 1;
            Barra = 1;
            Vigah = false;
            Vigaa = false;
        }


    }

}
