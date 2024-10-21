using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DisenoVigas.Models;
using DisenoVigas.Views;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;

using Windows.UI.Popups;
using static System.Net.Mime.MediaTypeNames;

namespace DisenoVigas.ViewModels;

public partial class DisenoViewModel : ObservableRecipient
{

    public DisenoPage view
    {
        get;

    }

    public Datos_DiseñoAFlexion disenoflexion { get; set; } = new Datos_DiseñoAFlexion();

    public Datos_Cortante datoscortante { get; set; } = new Datos_Cortante();

    public DisenoViewModel()
    {

        test = new RelayCommand(DiseñoVigas);


        //view = App.GetService<DisenoPage>();
       
        
    }


    public IRelayCommand test
    {
        get;
    }


    public ISeries[] SeriesChart
    {
        get; set;
    } =
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


    public void ChangeChartData()
    {
        var newSeries = new List<LineSeries<ObservablePoint>>
            {
                new LineSeries<ObservablePoint>
                {
                    Values = new List<ObservablePoint>
                    {
                        new ObservablePoint(10, -40),
                        new ObservablePoint(25, 10),
                        new ObservablePoint(35, 40)
                    },
                    GeometrySize = 5,
                    Stroke = new SolidColorPaint(SKColors.Blue),
                    LineSmoothness = 0
                },
                new LineSeries<ObservablePoint>
                {
                    Values = new List<ObservablePoint>
                    {
                        new ObservablePoint(15, 25),
                        new ObservablePoint(20, 30),
                        new ObservablePoint(30, 20)
                    },
                    GeometrySize = 5,
                    Stroke = new SolidColorPaint(SKColors.Green),
                    LineSmoothness = 0
                }
            };

        UpdateSeries(newSeries);
    }

    public void UpdateSeries(IEnumerable<LineSeries<ObservablePoint>> newSeries)
    {
        // Limpiar las series actuales
        SeriesChart = newSeries.ToArray();

        //view.charts.Series = SeriesChart;

        //view.charts.UpdateLayout();
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

        //Viga Viga1 = new Viga(b, h, dprima, dprima, fc, fy, Mu, VigaSimica, 0.004f, VigaSimica2);
        //Viga1.Diseñar();
        //es = Viga1.es;
        //esP = Viga1.esP;

        ////SR_DR.Visible = true;



        //if (Viga1.VSD == VigaSRDR.SR)
        //{
        //    //SR_DR.Text = "VIGA SIMPLEMENTE REFORZADA";
        //    //SR_DR.ForeColor = Color.Green;
        //    //OvalShape1.Visible = true;
        //    //OvalShape2.Visible = true;
        //    //OvalShape4.Visible = false;
        //    //OvalShape3.Visible = false;
        //}
        //else
        //{
        //    //OvalShape4.Visible = true;
        //    //OvalShape3.Visible = true;
        //    //SR_DR.Text = "VIGA DOBLEMENTE REFORZADA";
        //    //SR_DR.ForeColor = Color.Blue;
        //}

        //if (Viga1.Resultados.Rest.Item1.Contains("Cuantia"))
        //{
        //    //PictureBox1.Visible = true;
        //    //string Resultado = Viga1.Resultados.Rest.Item1;
        //    //PDimensionesInsuficientes.Visible = true;
        //    //PDimensionesInsuficientes.BringToFront();
        //    //LB_Deformaciones.Visible = false;
        //}
        //else
        //{
        //    //PictureBox1.Visible = false;
        //    //PDimensionesInsuficientes.Visible = false;
        //    //LB_Deformaciones.Visible = true;
        //}



        //var newSeries = new List<LineSeries<ObservablePoint>>
        //    {
        //        new LineSeries<ObservablePoint>
        //        {
        //            Values = new List<ObservablePoint>
        //            {
        //                new ObservablePoint(0, h ),
        //                new ObservablePoint(0.003, h ),
        //                new ObservablePoint(0, h - Viga1.c),
        //                new ObservablePoint(-(0.003 * (h - Viga1.c) / Viga1.c), 0 ),
        //                new ObservablePoint( 0, 0)
        //            },
        //            GeometrySize = 0,
        //            Fill = null,
        //            Stroke = new SolidColorPaint(SKColors.Blue),
        //            LineSmoothness = 0 // 0 para línea sin suavizado
        //        },
        //        new LineSeries<ObservablePoint>
        //        {
        //           Values = new List<ObservablePoint>
        //           {
        //                new ObservablePoint( 0, h - d ),
        //                new ObservablePoint(-es, h - d )
        //           },
        //           GeometrySize = 0,
        //           Fill = null,
        //           Stroke = new SolidColorPaint(SKColors.DarkBlue),
        //           LineSmoothness = 0 // 0 para línea sin suavizado
        //        },
        //       new LineSeries<ObservablePoint>
        //       {
        //            Values = new List<ObservablePoint>
        //            {
        //                new ObservablePoint(0, d),
        //                new ObservablePoint( esP, d),
        //            },
        //            GeometrySize = 0,
        //            Fill = null,
        //            Stroke = new SolidColorPaint(SKColors.Red),
        //            LineSmoothness = 0 // 0 para línea sin suavizado
        //       }
        //    };

        //double pt = Viga1.Resultados.Item6 / (d * b);
        //double pc = Viga1.Resultados.Item7 / (d * b);

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

        //UpdateSeries(newSeries);

        //RevisionVigas.Graficar_DiagramaDeforma(Chart1, Points, PointsDefT, PointsDeformC);
    }




    //[RelayCommand]
    //public void newtext()
    //{


    //}


    ////para pensar 
    //[RelayCommand(CanExecute = nameof(CanSubmit))]
    //private void Submit()
    //{
    //    // Lógica a ejecutar cuando el comando se ejecute
    //    System.Diagnostics.Debug.WriteLine($"Texto ingresado: {text}");
    //}

    //private bool CanSubmit()
    //{
    //    // El comando solo se puede ejecutar si hay texto en InputText
    //    return !string.IsNullOrWhiteSpace(text);
    //}


    #region como reparar, Microsoft.UI.x..interop.targets

        //<CompileXaml Condition = "'$(UseXamlCompilerExecutable)' != 'true'"
        //        LanguageSourceExtension="$(DefaultLanguageSourceExtension)"
        //        Language="$(XamlLanguage)"
        //        RootNamespace="$(RootNamespace)"
        //        XamlPages="@(Page)"
        //        XamlApplications="@(ApplicationDefinition)"
        //        PriIndexName="$(PriIndexName)"
        //        ProjectName="$(XamlProjectName)"
        //        IsPass1="True"
        //        CodeGenerationControlFlags="$(XamlCodeGenerationControlFlags)"
        //        ProjectPath="$(MSBuildProjectFullPath)"
        //        CIncludeDirectories="$(XamlCppIncludeDirectories)"
        //        OutputPath="$(XamlGeneratedOutputPath)"
        //        OutputType="$(OutputType)"
        //        ReferenceAssemblyPaths="@(ReferenceAssemblyPaths)"
        //        ReferenceAssemblies="@(ReferencePath)"
        //        ForceSharedStateShutdown="False"
        //        CompileMode="RealBuildPass1"
        //        XAMLFingerprint="$(XAMLFingerprint)"
        //        UseVCMetaManaged="$(UseVCMetaManaged)"
        //        FingerprintIgnorePaths="$(XAMLFingerprintIgnorePaths)"
        //        VCInstallDir="$(VCInstallDir)"
        //        SavedStateFile="$(XamlSavedStateFilePath)"
        //        SuppressWarnings="$(SuppressXamlWarnings)"
        //        TargetPlatformMinVersion="$(TargetPlatformMinVersion)"
        //        WindowsSdkPath="$(WindowsSdkPath)"
        //        XamlResourceMapName="$(XamlResourceMapName)"
        //        XamlComponentResourceLocation="$(XamlComponentResourceLocation)"
        //        FeatureControlFlags="@(XamlFeatureControlFlags)"
        //        VCInstallPath32="$(VCInstallPath32)"
        //        VCInstallPath64="$(VCInstallPath64)"
        //        GenXbfPath="$(GenXbfPath)"
        //        PrecompiledHeaderFile="$(PrecompiledHeaderFile)" >

        //        <Output Condition = " '$(ManagedAssembly)'!='false' " ItemName="Compile"   TaskParameter="GeneratedCodeFiles" />

        //        <!--
        //            FileWrites is used in Microsoft.Common.Targets for "Clean" build
        //        -->
        //        <Output ItemName = "FileWrites" TaskParameter="GeneratedCodeFiles" />
        //        <Output ItemName = "FileWrites" TaskParameter="GeneratedXamlFiles" />
        //        <Output ItemName = "FileWrites" TaskParameter="GeneratedXbfFiles" />
        //        <Output ItemName = "_GeneratedCodeFiles" TaskParameter="GeneratedCodeFiles" />
        //        <Output ItemName = "_GeneratedXamlFiles" TaskParameter="GeneratedXamlFiles" />
        //        <Output ItemName = "_GeneratedXbfFiles" TaskParameter="GeneratedXbfFiles" />
        //    </CompileXaml>

        #endregion


}
