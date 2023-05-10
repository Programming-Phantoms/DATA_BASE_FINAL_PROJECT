using System.Data;
using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Oracle.ManagedDataAccess.Client;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADD_CLASSPage : Page
{
    OracleConnection con;
    public ADD_CLASSViewModel ViewModel
    {
        get;
    }

    public ADD_CLASSPage()
    {
        ViewModel = App.GetService<ADD_CLASSViewModel>();
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
        bool intSem = int.TryParse(semText.Text, out int semester);
        bool intCap = int.TryParse(capText.Text, out int capacity);

        Error.Title = "Warning! ⚠";
        if (cidText.Text.Length == 0)
        {
            Error.Subtitle = "Class ID cannot be NULL!";
        }
        else if (cidText.Text.Length > 4)
        {
            Error.Subtitle = "Class id has " + (cidText.Text.Length - 4).ToString() + " extra character(s)!";
        }
        else if (cidText.Text.Length < 4)
        {
            Error.Subtitle = "Class id requires at least " + (4 - cidText.Text.Length).ToString() + " more character(s)!";
        }
        if (tidText.Text.Length == 0)
        {
            Error.Subtitle = "Teacher ID cannot be NULL!";
        }
        else if (tidText.Text.Length > 4)
        {
            Error.Subtitle = "Teacher id has " + (tidText.Text.Length - 4).ToString() + " extra character(s)!";
        }
        else if (tidText.Text.Length < 4)
        {
            Error.Subtitle = "Teacher id requires at least " + (4 - tidText.Text.Length).ToString() + " more character(s)!";
        }
        else if (semText.Text.Length == 0)
        {
            Error.Subtitle = "Semester cannot be NULL!";
        }
        else if (intSem && (semester > 8))
        {
            Error.Subtitle = "Semester cannot be greater than 8!";
        }
        else if (intSem && (semester < 1))
        {
            Error.Subtitle = "Semester cannot be lesser than 1!";
        }
        else if (!intSem)
        {
            Error.Subtitle = "Enter numeric value in semester!";
        }
        else if (secText.Text.Length == 0)
        {
            Error.Subtitle = "Section cannot be NULL!";
        }
        else if (secText.Text.Length > 1)
        {
            Error.Subtitle = "Section has " + (secText.Text.Length - 1).ToString() + " extra character(s)!";
        }
        else if (intCap && (capacity > 100))
        {
            Error.Subtitle = "Capacity cannot be greater than 100!";
        }
        else if (intCap && (capacity < 10))
        {
            Error.Subtitle = "Capacity cannot be lesser than 10!";
        }
        else if (!intCap)
        {
            Error.Subtitle = "Enter numeric value in capacity!";
        }
        else
        {
            con.Open();
            OracleCommand insertEmp = con.CreateCommand();
            insertEmp.CommandType = CommandType.Text;
            insertEmp.CommandText = "INSERT INTO CLASS VALUES('" +
            cidText.Text.ToString() + "\',\'" +
            tidText.Text.ToString() + "\',\'" +
            secText.Text.ToString() + "\'," +
            semText.Text.ToString() + "," +
            capText.Text.ToString() +
            ")";
            insertEmp.ExecuteNonQuery();
            con.Close();
            Error.Title = "Successfull! ✔️";
            Error.Subtitle = "New student added successfully!";
        }

        Error.IsOpen = true;
        Error.RequestedTheme = ElementTheme.Light;
    }
}
