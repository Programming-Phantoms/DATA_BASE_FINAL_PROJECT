using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class MY_SCHEDULEPage : Page
{
    public MY_SCHEDULEViewModel ViewModel
    {
        get;
    }

    public MY_SCHEDULEPage()
    {
        ViewModel = App.GetService<MY_SCHEDULEViewModel>();
        InitializeComponent();
    }
}
