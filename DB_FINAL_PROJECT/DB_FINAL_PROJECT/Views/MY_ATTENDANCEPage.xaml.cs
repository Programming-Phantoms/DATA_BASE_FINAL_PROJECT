using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class MY_ATTENDANCEPage : Page
{
    public MY_ATTENDANCEViewModel ViewModel
    {
        get;
    }

    public MY_ATTENDANCEPage()
    {
        ViewModel = App.GetService<MY_ATTENDANCEViewModel>();
        InitializeComponent();
    }
}
