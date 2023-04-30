using System.Data;
using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Oracle.ManagedDataAccess.Client;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_TEACHERPage : Page
{
    public ADD_TEACHERViewModel ViewModel
    {
        get;
    }

    public ADD_TEACHERPage()
    {
        ViewModel = App.GetService<ADD_TEACHERViewModel>();
        InitializeComponent();
        LoadOnPage();
    }

    private void LoadOnPage()
    {
        if (LoginPortal.LoginAdd)
        {
            Visible1.Visibility = Visible2.Visibility = Visible3.Visibility = Visibility.Visible;
        }
    }

    private void InsertButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void GenderMale_Click(object sender, RoutedEventArgs e)
    {
        genText.Content = "Male";
    }

    private void GenderFemale_Click(object sender, RoutedEventArgs e)
    {
        genText.Content = "Female";
    }

    private void GenderOther_Click(object sender, RoutedEventArgs e)
    {
        genText.Content = "Other";
    }

    private void BGAPositive_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "A+";
    }

    private void BGANegative_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "A-";
    }

    private void BGBPositive_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "B+";
    }

    private void BGBNegative_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "B-";
    }

    private void BGABPositive_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "AB+";
    }

    private void BGABNegative_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "AB-";
    }

    private void BGOBPositive_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "O+";
    }

    private void BGOBNegative_Click(object sender, RoutedEventArgs e)
    {
        bgText.Content = "O-";
    }
    private void FeePaid_Click(object sender, RoutedEventArgs e)
    {
        feeText.Content = "Paid";
    }
    private void FeeUnpaid_Click(object sender, RoutedEventArgs e)
    {
        feeText.Content = "Unpaid";
    }
}
