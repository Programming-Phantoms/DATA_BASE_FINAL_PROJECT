using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class VIEW_STUDENTS_IN_CLASSPage : Page
{
    public VIEW_STUDENTS_IN_CLASSViewModel ViewModel
    {
        get;
    }

    public VIEW_STUDENTS_IN_CLASSPage()
    {
        ViewModel = App.GetService<VIEW_STUDENTS_IN_CLASSViewModel>();
        InitializeComponent();
    }
}
