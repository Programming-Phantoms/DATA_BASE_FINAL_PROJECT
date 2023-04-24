using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class STUDENTPage : Page
{
    public STUDENTViewModel ViewModel
    {
        get;
    }

    public STUDENTPage()
    {
        ViewModel = App.GetService<STUDENTViewModel>();
        InitializeComponent();
    }
}
