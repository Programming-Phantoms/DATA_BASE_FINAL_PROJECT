using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_CLASSPage : Page
{
    public ADD_CLASSViewModel ViewModel
    {
        get;
    }

    public ADD_CLASSPage()
    {
        ViewModel = App.GetService<ADD_CLASSViewModel>();
        InitializeComponent();
    }
}
