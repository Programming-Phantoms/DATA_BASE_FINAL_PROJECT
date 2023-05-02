using System.Data;
using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

using Oracle.ManagedDataAccess.Client;
using static DB_FINAL_PROJECT.App;

public sealed partial class ADD_STUDENTPage : Page
{
    //OracleConnection con;
    public ADD_STUDENTViewModel ViewModel
    {
        get;
    }

    public ADD_STUDENTPage()
    {
        ViewModel = App.GetService<ADD_STUDENTViewModel>();
        InitializeComponent();
        LoadOnPage();

        //string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = F21_9243; PASSWORD = 1234";
        //con = new OracleConnection(conStr);
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
        //con.Open();
        //OracleCommand insertEmp = con.CreateCommand();
        //insertEmp.CommandText = "INSERT INTO STD VALUES('" +
        //fnameText.Text.ToString() + "\',\'" +
        //rollText.Text.ToString() + "\')";
        //insertEmp.CommandType = CommandType.Text;
        //insertEmp.ExecuteNonQuery();
        //con.Close();
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