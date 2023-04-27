using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_CLASS_SCHEDULEPage : Page
{
    public ADD_CLASS_SCHEDULEViewModel ViewModel
    {
        get;
    }

    public ADD_CLASS_SCHEDULEPage()
    {
        ViewModel = App.GetService<ADD_CLASS_SCHEDULEViewModel>();
        InitializeComponent();
    }
}
