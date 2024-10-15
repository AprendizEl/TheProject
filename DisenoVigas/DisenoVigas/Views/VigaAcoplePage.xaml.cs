using DisenoVigas.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DisenoVigas.Views;

public sealed partial class VigaAcoplePage : Page
{
    public VigaAcopleViewModel ViewModel
    {
        get;
    }

    public VigaAcoplePage()
    {
        ViewModel = App.GetService<VigaAcopleViewModel>();
        InitializeComponent();
    }
}
