using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_CLASS_SCHEDULEPage : Page
{
    public ADD_CLASS_SCHEDULEViewModel ViewModel
    {
        get;
    }

    public ADD_CLASS_SCHEDULEPage()
    {
        ViewModel = App.GetService<ADD_CLASS_SCHEDULEViewModel>();
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

    private void Monday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Monday";
    }

    private void Tuesday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Tuesday";
    }

    private void Wednesday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Wednesday";
    }

    private void Thursday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Thursday";
    }

    private void Friday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Friday";
    }

    private void Saturday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Saturday";
    }

    private void Sunday_Click(object sender, RoutedEventArgs e)
    {
        dowText.Content = "Sunday";
    }

    private void InsertButton_Click(object sender, RoutedEventArgs e)
    {
    }
}
