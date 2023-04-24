using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class LOGINPage : Page
{
    public LOGINViewModel ViewModel
    {
        get;
    }

    public LOGINPage()
    {
        ViewModel = App.GetService<LOGINViewModel>();
        InitializeComponent();
    }
}
