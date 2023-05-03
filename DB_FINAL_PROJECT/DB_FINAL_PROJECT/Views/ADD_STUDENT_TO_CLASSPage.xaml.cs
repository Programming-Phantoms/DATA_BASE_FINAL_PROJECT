using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using static DB_FINAL_PROJECT.App;

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
        LoadOnPage();
    }

    private void LoadOnPage()
    {
        if (LoginPortal.LoginAdd)
        {
            Visible1.Visibility = Visibility.Visible;
        }
    }

    private void InsertButton_Click(object sender, RoutedEventArgs e)
    {
    }
}
