using System.Data;
using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Oracle.ManagedDataAccess.Client;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;


public sealed partial class ADD_STUDENTPage : Page
{
    OracleConnection con;
    public ADD_STUDENTViewModel ViewModel
    {
        get;
    }

    public ADD_STUDENTPage()
    {
        ViewModel = App.GetService<ADD_STUDENTViewModel>();
        InitializeComponent();
        LoadOnPage();

        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = F21_9243; PASSWORD = 1234";
        con = new OracleConnection(conStr);
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
        if (rollText.Text.Length != 4)
        {
            Error.Subtitle = "Student ID cannot be NULL!";
        }
        else if (rollText.Text.Length != 4)
        {
            Error.Subtitle = "Student ID should be of length 4!";
        }
        else if (fnameText.Text.Length == 0)
        {
            Error.Subtitle = "First name cannot be NULL!";
        }
        else if (fnameText.Text.Length > 15)
        {
            Error.Subtitle = "First Name cannot be longer than 15 characters!";
        }
        else if (lnameText.Text.Length == 0)
        {
            Error.Subtitle = "Last Name cannot be NULL!";
        }
        else if (lnameText.Text.Length > 15)
        {
            Error.Subtitle = "Last Name cannot be longer than 15 characters!";
        }
        else if (contactText.Text.Length != 11)
        {
            Error.Subtitle = "Contact number should be of length of 11!";
        }
        else if (addText.Text.Length == 0)
        {
            Error.Subtitle = "Address cannot be NULL!";
        }
        else if (addText.Text.Length > 50)
        {
            Error.Subtitle = "Address too long!";
        }
        else if (passText.Password.Length > 15)
        {
            Error.Subtitle = "Password too large!";
        }
        else if (passText.Password.Length == 0)
        {
            Error.Subtitle = "Password cannot be NULL!";
        }
        else if (regText.SelectedDate == null)
        {
            Error.Subtitle = "Date not selected!";
        }
        else if (genText.Content.ToString() == "Gender")
        {
            Error.Subtitle = "Gender not selected!";
        }
        else if (feeText.Content.ToString() == "Fee status")
        {
            Error.Subtitle = "Fee status not selected!";
        }
        else if (bgText.Content.ToString() == "Blood Group")
        {
            Error.Subtitle = "Blood group not selected!";
        }
        else
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandType = CommandType.Text;
            insertEmp.CommandText = "INSERT INTO STUDENT VALUES('" +
            rollText.Text.ToString() + "\',\'" +
            addText.Text.ToString() + "\',\'" +
            fnameText.Text.ToString() + "\',\'" +
            lnameText.Text.ToString() + "\',\'" +
            feeText.Content.ToString() + "\',";
            insertEmp.CommandText += "TO_DATE('" + regText.SelectedDate.Value.ToString("MM/dd/yyyy") + "', 'MM/DD/YYYY')" + ",\'";
            insertEmp.CommandText += genText.Content.ToString() + "\',\'" +
            contactText.Text.ToString() + "\',\'" +
            passText.Password.ToString() + "\',\'" +
            bgText.Content.ToString() +
            "\')";
            insertEmp.ExecuteNonQuery();
            con.Close();
            Error.Title = "Successfull! ✔️";
            Error.Subtitle = "New student added successfully!";
        }

        Error.IsOpen = true;
        Error.RequestedTheme = ElementTheme.Light;
        
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