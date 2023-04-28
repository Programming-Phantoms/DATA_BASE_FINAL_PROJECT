using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_STUDENT_TO_CLASSPage : Page
{
    public ADD_STUDENT_TO_CLASSViewModel ViewModel
    {
        get;
    }

    public ADD_STUDENT_TO_CLASSPage()
    {
        ViewModel = App.GetService<ADD_STUDENT_TO_CLASSViewModel>();
        InitializeComponent();
    }
}
