using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Forms;
using System.Windows.Input;
using TheProject.Models;
using TheProject.Controls;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;

namespace TheProject.ViewModels
{
    public partial class VM_VRegister : ObservableObject
    {
        public M_User usert { get; set; } = new M_User();

        public Datos_DiseñoAFlexion disenoflexion { get; set; } = new Datos_DiseñoAFlexion();

        public int D { get; set; } 

        public Datos_Cortante Datos_Cortante { get; set; } = new Datos_Cortante();

        public VM_VRegister()
        {

            D = disenoflexion.D;

            //summoner.Name = "Example";
            //summoner.Level = 0;
            //summoner.Region = LeagueRegion.TR;
            //summoner.Rank = LeagueRank.Unranked;
            //summoner.Phrase = "I am the best";

            //ranks = Enum.GetValues(typeof(LeagueRank)).Cast<LeagueRank>().ToList();
            //regions = Enum.GetValues(typeof(LeagueRegion)).Cast<LeagueRegion>().ToList();

            save = new RelayCommand(OnSaveSummoner);

            saveAll = new RelayCommand(OnSaveAll);



        }

        #region
        public ICommand save { get; }

        public ICommand saveAll { get; }



        private void setD()
        {
            //summoner.Name = "Example";
            //summoner.Level = 0;
            //summoner.Region = LeagueRegion.TR;
            //summoner.Rank = LeagueRank.Unranked;
            //summoner.Phrase = "I am the best";
            


        }

        public ISeries[] Series { get; set; } =
{
    new LineSeries<System.Windows.Point>
    {
        Values = new List<System.Windows.Point>
        {
            new System.Windows.Point(10, 20),
            new System.Windows.Point(30, 40),
            new System.Windows.Point(50, 60)
        },
        GeometrySize = 1,
        LineSmoothness = 0, // 0 para una línea sin suavizado
        Stroke = new SolidColorPaint(SKColors.Red), // Color rojo
        // Grosor de la línea
    }
};

        private void OnSaveSummoner()
        {
            App.register.Charts.UpdateLayout();
            App.register.Series = Series;
            //summoners.Add(new M_Summoner().build(summoner));
            //setD();
        }

        private void OnSaveAll()
        {


            //Tools tools = new Tools();
            //var loadedSummoners = tools.LoadFromBinaryFile<M_Summoner>("C:\\Users\\eecheto\\Desktop\\MyProjet\\Prueba4\\TheProject\\TheProject\\Controls\\summoners.dat");

            ////    tools.SaveToBinaryFile(summoners, "C:\\Users\\eecheto\\Desktop\\MyProjet\\Prueba4\\TheProject\\TheProject\\Controls\\summoners.dat");
        }

        public static async Task ContarConEsperaAsync()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(5000); // Espera 5000 milisegundos (5 segundos) de manera asíncrona
            }
        }

        public static async Task tem()
        {

            var s = ContarConEsperaAsync();


            await s;

            MessageBox.Show("finish");
        }

        #endregion

    }
}
