using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_STUDENTPage : Page
{
    public ADD_STUDENTViewModel ViewModel
    {
        get;
    }

    public ADD_STUDENTPage()
    {
        ViewModel = App.GetService<ADD_STUDENTViewModel>();
        InitializeComponent();
    }
}
