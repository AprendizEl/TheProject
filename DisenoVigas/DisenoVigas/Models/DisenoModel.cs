using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.Xaml.Interactions.Core;
using SkiaSharp;
using Windows.Foundation.Collections;

namespace DisenoVigas.Models
{
    public partial class DisenoModel : ObservableObject
    {
        [ObservableProperty]
        private ISeries[] seriesChart;
      


    }


    public partial class Datos_DiseñoAFlexion : ObservableObject
    {

        [ObservableProperty]
        private float d;

        [ObservableProperty]
        private float d2;

        [ObservableProperty]
        private float b;

        [ObservableProperty]
        private float fc;

        [ObservableProperty]
        private float fy;

        [ObservableProperty]
        private float mu;

        [ObservableProperty]
        private bool vigas;

        [ObservableProperty]
        private bool vigans;

        public Datos_DiseñoAFlexion()
        {
            D = 35;
            D2 = 5;
            B = 30;
            D2 = 5;
            Fc = 210;
            Fy = 4220;
            mu = 1;
            vigas = false;
            vigans = false;
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
        private float ramas;

        [ObservableProperty]
        private float barra;

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


    public partial class DatosVigaAcoples : ObservableObject
    {

        [ObservableProperty]
        private float fc;

        [ObservableProperty]
        private float vu;

        [ObservableProperty]
        private float bw;

        [ObservableProperty]
        private float fy;

        [ObservableProperty]
        private float luz;

        [ObservableProperty]
        private float h;

        [ObservableProperty]
        private float d2;

        [ObservableProperty]
        private string barraAsh;

        [ObservableProperty]
        private float recubrimiento;

        [ObservableProperty]
        private string barrasAvd;

        [ObservableProperty]
        private string barrasPiel;

        public DatosVigaAcoples()
        {

            Fc = 350;
            Vu = 83.8f;
            Bw = 0.25f; 
            Fy = 4220;
            Luz = 1.2f;
            H = 0.9f;
            D2 = 0;
            Recubrimiento = 5.0f;


            BarraAsh = "N°3";
            BarrasAvd = "N°1";
            BarrasPiel = "N°4";







        }

    }

}
