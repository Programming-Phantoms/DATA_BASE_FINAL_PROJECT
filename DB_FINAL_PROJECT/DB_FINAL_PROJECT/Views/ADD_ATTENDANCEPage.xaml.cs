using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_ATTENDANCEPage : Page
{
    public ADD_ATTENDANCEViewModel ViewModel
    {
        get;
    }

    public ADD_ATTENDANCEPage()
    {
        ViewModel = App.GetService<ADD_ATTENDANCEViewModel>();
        InitializeComponent();
    }
}
