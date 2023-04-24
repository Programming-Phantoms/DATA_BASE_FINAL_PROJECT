using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class TEACHERPage : Page
{
    public TEACHERViewModel ViewModel
    {
        get;
    }

    public TEACHERPage()
    {
        ViewModel = App.GetService<TEACHERViewModel>();
        InitializeComponent();
    }
}
