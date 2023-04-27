using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class EDIT_TEACHERPage : Page
{
    public EDIT_TEACHERViewModel ViewModel
    {
        get;
    }

    public EDIT_TEACHERPage()
    {
        ViewModel = App.GetService<EDIT_TEACHERViewModel>();
        InitializeComponent();
    }
}
