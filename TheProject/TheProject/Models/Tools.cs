using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

using System.Threading.Tasks;

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
        private int d;

        [ObservableProperty]
        private int d2;

        [ObservableProperty]
        private int r;

        [ObservableProperty]
        private int b;

        [ObservableProperty]
        private int fc;

        [ObservableProperty]
        private int fy;

        [ObservableProperty]
        private int vu;

        [ObservableProperty]
        private int t;

        [ObservableProperty]
        private string ramas;

        [ObservableProperty]
        private string barra;

        [ObservableProperty]
        private bool vigah;

        [ObservableProperty]
        private bool vigaa;

        public Datos_Cortante()
        {
            d = 0;
            d2 = 5;
            r = 0;
            b = 0;
            fc = 0;
            fy = 0;
            vu = 0;
            t = 0;
            ramas = "1";
            barra = "1";
            vigah = false;
            vigaa = false;
        }

    }

}
