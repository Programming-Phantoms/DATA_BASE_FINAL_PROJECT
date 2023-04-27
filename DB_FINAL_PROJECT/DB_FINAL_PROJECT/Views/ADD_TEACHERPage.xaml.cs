using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_TEACHERPage : Page
{
    public ADD_TEACHERViewModel ViewModel
    {
        get;
    }

    public ADD_TEACHERPage()
    {
        ViewModel = App.GetService<ADD_TEACHERViewModel>();
        InitializeComponent();
    }
}
