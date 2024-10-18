using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigaRD;
using TheProject.Models;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Windows.Forms;

namespace TheProject.ViewModels
{
    internal class VM_DisenoPage
    {
        public Datos_DiseñoAFlexion disenoflexion { get; set; } = new Datos_DiseñoAFlexion();

        public Datos_Cortante datoscortante { get; set; } = new Datos_Cortante();


        public VM_DisenoPage()
        {





            test = new RelayCommand(DiseñoVigas);

        }


        public ICommand test { get; }


        public ISeries[] SeriesChart { get; set; } =
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
            },

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
            },

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

        public void UpdateSeries(IEnumerable<LineSeries<ObservablePoint>> newSeries)
        {
            // Limpiar las series actuales
            SeriesChart = newSeries.ToArray();

            App.disenoPage.Charts.Series = SeriesChart;

            App.disenoPage.Charts.UpdateLayout();
        }

        private void DiseñoVigas()
        {
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

            //Panel4.Visible = true;
            //LB_Deformaciones.Visible = true;

            Viga Viga1 = new Viga(b, h, dprima, dprima, fc, fy, Mu, VigaSimica,0.004f , VigaSimica2);
            Viga1.Diseñar();
            es = Viga1.es;
            esP = Viga1.esP;

            //SR_DR.Visible = true;



            if (Viga1.VSD == VigaSRDR.SR)
            {
                //SR_DR.Text = "VIGA SIMPLEMENTE REFORZADA";
                //SR_DR.ForeColor = Color.Green;
                //OvalShape1.Visible = true;
                //OvalShape2.Visible = true;
                //OvalShape4.Visible = false;
                //OvalShape3.Visible = false;
            }
            else
            {
                //OvalShape4.Visible = true;
                //OvalShape3.Visible = true;
                //SR_DR.Text = "VIGA DOBLEMENTE REFORZADA";
                //SR_DR.ForeColor = Color.Blue;
            }

            if (Viga1.Resultados.Rest.Item1.Contains("Cuantia"))
            {
                //PictureBox1.Visible = true;
                //string Resultado = Viga1.Resultados.Rest.Item1;
                //PDimensionesInsuficientes.Visible = true;
                //PDimensionesInsuficientes.BringToFront();
                //LB_Deformaciones.Visible = false;
            }
            else
            {
                //PictureBox1.Visible = false;
                //PDimensionesInsuficientes.Visible = false;
                //LB_Deformaciones.Visible = true;
            }



            var newSeries = new List<LineSeries<ObservablePoint>>
            {
                new LineSeries<ObservablePoint>
                {
                    Values = new List<ObservablePoint>
                    {
                        new ObservablePoint(0, h ),
                        new ObservablePoint(0.003, h ),
                        new ObservablePoint(0, h - Viga1.c),
                        new ObservablePoint(-(0.003 * (h - Viga1.c) / Viga1.c), 0 ),
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
                        new ObservablePoint(-es, h - d )
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
                        new ObservablePoint( esP, d),
                    },
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.Red),
                    LineSmoothness = 0 // 0 para línea sin suavizado
               },
            };

            double pt = Viga1.Resultados.Item6 / (d * b);
            double pc = Viga1.Resultados.Item7 / (d * b);

            //Label16.Text = Viga1.fi.ToString("#0.000");
            //Label29.Text = pt.ToString("#0.0000");
            //Label30.Text = pc.ToString("#0.0000");

            //// As
            //Label1.Text = Viga1.Resultados.Item6.ToString("#0.00");
            //Label22.Left = Label1.Width + Label1.Left - 5;

            //// As'
            //Label19.Text = Viga1.Resultados.Item7.ToString("#0.00");
            //Label21.Left = Label19.Width + Label19.Left - 5;

            //// Mmax
            //Label25.Text = (Viga1.Resultados.Item2 / 100000).ToString("#0.00");
            //Label24.Left = Label25.Width + Label25.Left - 5;

            //es_L.Text = es.ToString("#0.00000");
            //esP_L.Text = esP.ToString("#0.00000");

            UpdateSeries(newSeries);

            App.disenoPage.Charts.UpdateLayout();
            //RevisionVigas.Graficar_DiagramaDeforma(Chart1, Points, PointsDefT, PointsDeformC);
        }

        public void DisenoCortanteyTorsion()
        {
            double Vu = datoscortante.Vu * 1000; // kgf
            double fi = 0.75;
            double b = datoscortante.B; // cm
            double d = datoscortante.D; // cm
            double fc = datoscortante.Fc; // kg/cm2
            double fy = datoscortante.Fy; // kg/cm2
            double dprima = datoscortante.D2;
            double[] Av = new double[11];
            double fi_vc = fi * 0.53 * b * d * Math.Sqrt(fc);
            double AceroCortante, s;
            double smax = 0;
            double AceroaColocar, Ramas;
            double T = datoscortante.T * 100000; // kgf*cm2
            double r = datoscortante.R; // cm

            Av[1] = 0; Av[2] = 0.32; Av[3] = 0.71; Av[4] = 1.29; Av[5] = 1.99;
            Av[6] = 2.84; Av[7] = 3.87; Av[8] = 5.1; Av[9] = 0; Av[10] = 8.19;

            Ramas = datoscortante.Ramas;
            AceroCortante = Av[datoscortante.Barra] * Ramas;
            double fi_vs = Vu - fi_vc;
            AceroaColocar = Ramas * Av[datoscortante.Barra];

            if (fi_vs < 0)
            {
                fi_vs = 0;
            }

            // Separaciones máximas
            if (0 <= fi_vs / fi && fi_vs / fi <= 1.1 * Math.Sqrt(fc) * b * d)
            {
                smax = (d / 2 < 60) ? d / 2 : 60;
            }
            else if (1.1 * Math.Sqrt(fc) * b * d < fi_vs / fi && fi_vs / fi <= 2.2 * Math.Sqrt(fc) * b * d)
            {
                smax = (d / 4 < 30) ? d / 4 : 30;
            }

            if (Vu > fi_vc)
            {
                // Se requiere Estribos

                //FormRec.Panel9.Visible = true;
                //FormRec.Vc.Text = Math.Round((fi_vc) / 1000, 2).ToString();
                //FormRec.Label61.Left = FormRec.Vc.Width + FormRec.Vc.Left - 5;
                //FormRec.Vs.Text = Math.Round((fi_vs) / 1000, 2).ToString();
                //FormRec.Label62.Left = FormRec.Vs.Width + FormRec.Vs.Left - 5;
                //FormRec.Label55.Visible = false;
                //FormRec.Label59.Visible = false;
                //FormRec.smax.Visible = false;
                //FormRec.Error1.Visible = false;
                //FormRec.P_Esfuerzos.Visible = false;

                double fi_vsmax = fi * 2.2 * Math.Sqrt(fc) * b * d; // C.11.4.7.9
                double fi_vnmax = fi_vsmax + fi_vc;

                if (datoscortante.Vigaa)
                {
                    fi_vnmax = fi * 2.65 * Math.Sqrt(fc) * b * d;
                    fi_vsmax = fi_vnmax - fi_vc;
                }

                if (fi_vs <= fi_vsmax)
                {
                    s = (fi * AceroCortante * fy * d) / (fi_vs); // cm

                    if (s > smax)
                    {
                        //FormRec.Label55.Visible = true;
                        //FormRec.Label59.Visible = true;
                        //FormRec.smax.Visible = true;
                        //FormRec.Error1.Visible = true;
                        //FormRec.smax.Text = Math.Round(smax, 2).ToString();
                        //FormRec.Label59.Left = FormRec.smax.Width + FormRec.smax.Left - 5;
                    }

                    //FormRec.S.Text = Math.Round(s, 2).ToString();
                    //FormRec.Label52.Left = FormRec.S.Width + FormRec.S.Left - 5;

                    //FormRec.Vsmax.Text = Math.Round((fi_vsmax) / 1000, 2).ToString();
                    //FormRec.Label67.Left = FormRec.Vsmax.Width + FormRec.Vsmax.Left - 5;

                    //FormRec.vnmax.Text = Math.Round((fi_vnmax) / 1000, 2).ToString();
                    //FormRec.Label49.Left = FormRec.vnmax.Width + FormRec.vnmax.Left - 5;

                    //FormRec.Al.Visible = false;
                    //FormRec.Label68.Visible = false;
                    //FormRec.Label69.Visible = false;
                }
                else
                {
                    //FormRec.Vsmax.Text = Math.Round((fi_vsmax) / 1000, 2).ToString();
                    //FormRec.Label67.Left = FormRec.Vsmax.Width + FormRec.Vsmax.Left - 5;

                    //FormRec.vnmax.Text = Math.Round((fi_vnmax / 1000), 2).ToString();
                    //FormRec.Label49.Left = FormRec.vnmax.Width + FormRec.vnmax.Left - 5;
                    //MessageBox.Show("Dimensiones Insuficientes por Cortante", "efe-Prima-ce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //FormRec.S.Text = "";
                    //FormRec.Label52.Left = FormRec.S.Width + FormRec.S.Left - 5;
                }
            }
            else
            {
                MessageBox.Show("No se requiere Estribos por Cortante", "efe-Prima-ce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //FormRec.Panel9.Visible = false;
            }

            // At ----> 1m

            double EsfuerzoLimiteFisuracion = ((fi_vc) / (b * d) + 2 * fi * Math.Sqrt(fc)); // Esfuerzo limite por Fisuración // C.11.5.3.1 (C.11-18)
                                                                                            // Esfuerzo Inducido
            if (T != 0)
            {
                double Tultimo = 0;
                double Acp = (dprima + d) * (b);
                double Pcp = (2 * b + 2 * (d + dprima));
                //Tultimo = (FormRec.VigaHiperestatica.Checked) ?
                //    fi * Math.Sqrt(fc) * ((Acp * Acp) / Pcp) :
                //    fi * 0.27 * Math.Sqrt(fc) * ((Acp * Acp) / Pcp);

                double Aoh, Ph, Xo, Yo, MaximoVc, FactorMinimoVc, At, Al, Avn, Avtotal, MinimioAv, Almin, Ao;

                Xo = b - 2 * r;
                Yo = (d + dprima) - 2 * r;

                Aoh = Xo * Yo;
                Ao = 0.85 * Aoh;
                Ph = 2 * Xo + 2 * Yo;

                // Esfuerzo Inducido y Esfuerzo Limite
                //FormRec.P_Esfuerzos.Visible = true;

                double EsfuerzoInducido = Math.Sqrt(Math.Pow((Vu / (b * d)), 2) + Math.Pow((T * Ph) / (1.7 * Math.Pow(Aoh, 2)), 2));

                //FormRec.LB_ValueEsfuerzoInducido.Text = EsfuerzoInducido.ToString("0.00");
                //FormRec.LB_UnidEfuerzoInducido.Left = FormRec.LB_ValueEsfuerzoInducido.Left + FormRec.LB_ValueEsfuerzoInducido.Width - 5;

                //FormRec.LB_ValueEsfuerzoLimite.Text = EsfuerzoLimiteFisuracion.ToString("0.00");
                //FormRec.LB_UnidEsfuerzoLimite.Left = FormRec.LB_ValueEsfuerzoLimite.Left + FormRec.LB_ValueEsfuerzoLimite.Width - 5;

                //FormRec.LB_ComprobarEsfuerzo.Text = EsfuerzoInducido <= EsfuerzoLimiteFisuracion ? "✓ OK" : "✘ NO CUMPLE";
                //FormRec.LB_ComprobarEsfuerzo.ForeColor = EsfuerzoInducido <= EsfuerzoLimiteFisuracion ? Color.Blue : Color.Red;

                if (Tultimo < T)
                {
                    // Se Diseña por Torsión

                    MaximoVc = fi * (((fi_vc / fi) / (b * d) + (2 * Math.Sqrt(fc)))); // Esfuerzo limite por Fisuración // C.11.5.3.1 (C.11-18)
                    FactorMinimoVc = Math.Sqrt(((Vu / (b * d)) * (Vu / (b * d))) + ((T * Ph) / (1.7 * Aoh * Aoh)) * (T * Ph) / (1.7 * Aoh * Aoh)); // Esfuerzo Inducido

                    if (MaximoVc > FactorMinimoVc)
                    {
                        At = T / (2 * fi * Ao * fy); // /s
                        Avn = fi_vs / (fi * fy * d); // /s

                        double AvMinimo = (3.5 * b) / fy;
                        if (AvMinimo > Avn)
                        {
                            Avn = AvMinimo;
                        }

                        Avtotal = 2 * At + Avn; // Av/S=Factor
                        if (Ramas > 2)
                        {
                            AceroaColocar = 2 * Av[Convert.ToInt32(datoscortante.Barra)];
                        }
                        else if (Ramas == 1)
                        {
                            AceroaColocar = 0;
                        }
                        s = AceroaColocar / Avtotal;

                        MinimioAv = (0.2 * Math.Sqrt(fc) * b * s) / (fy);

                        if (MinimioAv >= (3.5 * b * s) / fy)
                        {
                            MessageBox.Show("Proponga otro Refuerzo", "efe-Prima-ce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Al = (T * Ph) / (2 * fi * Ao * fy); // C.11.5.3.7 (C.11-22)
                            if ((At / s) > (1.75 * b) / fy)
                            {
                                Almin = ((1.33 * Math.Sqrt(fc) * Acp) / fy) - (At / s) * Ph;
                            }
                            else
                            {
                                Almin = ((1.33 * Math.Sqrt(fc) * Acp) / fy) - ((1.75 * b) / fy) * Ph;
                            }

                            if (Al < Almin)
                            {
                                Al = Almin;
                            }

                            //FormRec.Panel9.Visible = true;
                            //FormRec.Vc.Text = Math.Round((fi_vc) / 1000, 2).ToString();
                            //FormRec.Label61.Left = FormRec.Vc.Width + FormRec.Vc.Left - 5;
                            //FormRec.Vs.Text = Math.Round((fi_vs) / 1000, 2).ToString();
                            //FormRec.Label62.Left = FormRec.Vs.Width + FormRec.Vs.Left - 5;
                            //FormRec.Label55.Visible = false;
                            //FormRec.Label59.Visible = false;
                            //FormRec.smax.Visible = false;
                            //FormRec.Error1.Visible = false;

                            //FormRec.S.Text = Math.Round(s, 2).ToString();
                            //FormRec.Label52.Left = FormRec.S.Width + FormRec.S.Left - 5;
                            //FormRec.vnmax.Text = Math.Round((fi * 2.65 * Math.Sqrt(fc) * b * d) / 1000, 2).ToString();
                            //FormRec.Label49.Left = FormRec.vnmax.Width + FormRec.vnmax.Left - 5;
                            //FormRec.Vsmax.Text = Math.Round((fi * 2.2 * Math.Sqrt(fc) * b * d) / 1000, 2).ToString();
                            //FormRec.Label67.Left = FormRec.Vsmax.Width + FormRec.Vsmax.Left - 5;

                            //FormRec.Al.Visible = true;
                            //FormRec.Label68.Visible = true;
                            //FormRec.Label69.Visible = true;

                            if (s > smax)
                            {
                                //FormRec.Label55.Visible = true;
                                //FormRec.Label59.Visible = true;
                                //FormRec.smax.Visible = true;
                                //FormRec.Error1.Visible = true;
                                //FormRec.smax.Text = Math.Round(smax, 2).ToString();
                                //FormRec.Label59.Left = FormRec.smax.Width + FormRec.smax.Left - 5;
                            }

                            //FormRec.Al.Text = Math.Round(Al, 2).ToString();
                            //FormRec.Label68.Left = FormRec.Al.Width + FormRec.Al.Left - 5;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dimensiones Insuficientes por Torsión", "efe-Prima-ce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    // No se diseña por Torsión
                    //FormRec.P_Esfuerzos.Visible = false;
                    MessageBox.Show("No se requiere Estribos por Torsión", "efe-Prima-ce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }





    }
}
