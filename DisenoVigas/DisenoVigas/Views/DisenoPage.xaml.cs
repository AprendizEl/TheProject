using DisenoVigas.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DisenoVigas.Views;

public sealed partial class DisenoPage : Page
{
    public DisenoViewModel ViewModel
    {
        get;
    }

    public DisenoPage()
    {
        ViewModel = App.GetService<DisenoViewModel>();
        InitializeComponent();
       
    }
}
