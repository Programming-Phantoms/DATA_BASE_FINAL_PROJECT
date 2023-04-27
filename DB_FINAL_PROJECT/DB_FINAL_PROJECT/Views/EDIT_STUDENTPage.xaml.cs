using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class EDIT_STUDENTPage : Page
{
    public EDIT_STUDENTViewModel ViewModel
    {
        get;
    }

    public EDIT_STUDENTPage()
    {
        ViewModel = App.GetService<EDIT_STUDENTViewModel>();
        InitializeComponent();
    }
}
