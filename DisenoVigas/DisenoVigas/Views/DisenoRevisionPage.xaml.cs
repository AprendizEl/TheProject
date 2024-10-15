using DisenoVigas.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DisenoVigas.Views;

public sealed partial class DisenoRevisionPage : Page
{
    public DisenoRevisionViewModel ViewModel
    {
        get;
    }

    public DisenoRevisionPage()
    {
        ViewModel = App.GetService<DisenoRevisionViewModel>();
        InitializeComponent();
    }
}
