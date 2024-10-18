using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using RevisionSRDR;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.Models;

namespace TheProject.ViewModels
{
    internal class VM_RevisionPage
    {
        public Datos_DiseñoAFlexion disenoflexion { get; set; } = new Datos_DiseñoAFlexion();

        public Datos_Cortante datoscortante { get; set; } = new Datos_Cortante();






        private void RevisionVigaSRDR()
        {
            float AceroCompresion = 0;
            float AceroTraccion = 0;
            float fc = disenoflexion.Fc;
            float fy = disenoflexion.Fy;
            float b = disenoflexion.D;
            float d = disenoflexion.B;
            float dprima = disenoflexion.D2;
            float h = dprima + d;
            float Mu = disenoflexion.Mu * 100000;
            bool VigaSimica = disenoflexion.Vigas;
            bool VigaSimica2 = disenoflexion.Vigans;
            double es, esP;


            // Configuración del color de las formas
            //OvalShape1.BackColor = Color.DarkGray;
            //OvalShape2.BackColor = Color.DarkGray;
            //OvalShape3.BackColor = Color.DarkGray;
            //OvalShape4.BackColor = Color.DarkGray;
            //OvalShape5.BackColor = Color.DarkGray;
            //OvalShape6.BackColor = Color.DarkGray;

            // Cálculo de la altura total

            // Creación y revisión de la viga
            VigaR Viga = new VigaR(b, h, d, dprima, fc, fy, AceroCompresion, AceroTraccion);
            Viga.Revision();

            // Verificación de dimensiones
            //if (Math.Abs(AceroTraccion - AceroCompresion) / (b_ * d) > 0.025)
            //{
            //    PDimensionesInsuficientes.Visible = true;
            //}
            //else
            //{
            //    PDimensionesInsuficientes.Visible = false;
            //}

            // Cálculo de MR_
            double MR_ = Viga.Mr / 100000;

            // Asignación de valores a GraficaFi
            //GraficaFi.fi = Viga.fi;
            //GraficaFi.et = Viga.es;

            // Preparación de puntos para el gráfico
            var newSeries = new List<LineSeries<ObservablePoint>>
            {
                new LineSeries<ObservablePoint>
                {
                    Values = new List<ObservablePoint>
                    {
                        new ObservablePoint(0, h ),
                        new ObservablePoint(0.003, h ),
                        new ObservablePoint(0, h - Viga.c),
                        new ObservablePoint(-(0.003 * (h - Viga.c) / Viga.c), 0 ),
                        new ObservablePoint( 0, 0)
                    },
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.LightBlue),
                    LineSmoothness = 0 // 0 para línea sin suavizado
                },
                new LineSeries<ObservablePoint>
                {
                   Values = new List<ObservablePoint>
                   {
                        new ObservablePoint( 0, h - d ),
                        //new ObservablePoint(-es, h - d )
                   },
                   GeometrySize = 0,
                   Fill = null,
                   Stroke = new SolidColorPaint(SKColors.DarkBlue),
                   LineSmoothness = 0 // 0 para línea sin suavizado
                },
               new LineSeries<ObservablePoint>
               {
                    Values = new List<ObservablePoint>
                    {
                        new ObservablePoint(0, d),
                        //new ObservablePoint( esP, d),
                    },
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.Red),
                    LineSmoothness = 0 // 0 para línea sin suavizado
               },
            };


            // Graficar el diagrama de deformación
            //Graficar_DiagramaDeforma(Chart1, Points, PointsDeformT, PointsDeformC);

            // Actualización de etiquetas
            //MR.Text = Math.Round(MR_, 2).ToString();
            //Label23.Left = MR.Width + MR.Left - 5;
            //Label72.Text = Math.Round(Viga.fi, 4).ToString();

            //es_L.Text = Viga.es.ToString("#0.00000");
            //esP_L.Text = Viga.esP.ToString("#0.00000");
        }












    }
}
