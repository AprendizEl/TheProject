using DisenoVigas.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DisenoVigas.Views;

public sealed partial class RevisionPage : Page
{
    public RevisionViewModel ViewModel
    {
        get;
    }

    public RevisionPage()
    {
        ViewModel = App.GetService<RevisionViewModel>();
        InitializeComponent();
    }
}
