using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADMINISTRATORPage : Page
{
    public ADMINISTRATORViewModel ViewModel
    {
        get;
    }

    public ADMINISTRATORPage()
    {
        ViewModel = App.GetService<ADMINISTRATORViewModel>();
        InitializeComponent();
    }
}
