using System.Data;
using System.Runtime.Intrinsics.Arm;
using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Oracle.ManagedDataAccess.Client;
using Windows.Devices.Enumeration;
using Windows.UI;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class LOGINPage : Page
{
    OracleConnection con;

    List<string> adm = new List<string>();
    List<string> tea = new List<string>();
    List<string> std = new List<string>();

    public LOGINViewModel ViewModel
    {
        get;
    }

    internal class ContentDialogContent
    {
        public ContentDialogContent()
        {
        }
    }

    public LOGINPage()
    {
        ViewModel = App.GetService<LOGINViewModel>();
        InitializeComponent();

        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = 21F_9250; PASSWORD = 1234";
        con = new OracleConnection(conStr);
        
        OnLoad();
    }

    private void OnLoad()
    {
        //Administrator
        con.Open();
        OracleCommand admId = con.CreateCommand();
        admId.CommandText = "SELECT a_id FROM ADMINISTRATOR";
        admId.CommandType = CommandType.Text;
        OracleDataReader AdmDR = admId.ExecuteReader();

        while (AdmDR.Read())
        {
            adm.Add(AdmDR.GetString(0).ToString());
        }
        AdmDR.Close();
        con.Close();

        con.Open();
        OracleCommand admPass = con.CreateCommand();
        admPass.CommandText = "SELECT a_password FROM ADMINISTRATOR";
        admPass.CommandType = CommandType.Text;
        OracleDataReader AdmPassDR = admPass.ExecuteReader();

        while (AdmPassDR.Read())
        {
            adm.Add(AdmPassDR.GetString(0).ToString());
        }
        AdmPassDR.Close();
        con.Close();

        // Teacher
        con.Open();
        OracleCommand TeaId = con.CreateCommand();
        TeaId.CommandText = "SELECT t_id FROM Teacher";
        TeaId.CommandType = CommandType.Text;
        OracleDataReader TeaDR = TeaId.ExecuteReader();

        while (TeaDR.Read())
        {
            tea.Add(TeaDR.GetString(0).ToString());
        }
        TeaDR.Close();
        con.Close();

        con.Open();
        OracleCommand teaPass = con.CreateCommand();
        teaPass.CommandText = "SELECT t_password FROM TEACHER";
        teaPass.CommandType = CommandType.Text;
        OracleDataReader TeaPassDR = teaPass.ExecuteReader();

        while (TeaPassDR.Read())
        {
            tea.Add(TeaPassDR.GetString(0).ToString());
        }
        TeaPassDR.Close();
        con.Close();

        // Student
        con.Open();
        OracleCommand StdId = con.CreateCommand();
        StdId.CommandText = "SELECT s_id FROM STUDENT";
        StdId.CommandType = CommandType.Text;
        OracleDataReader STDDR = StdId.ExecuteReader();

        while (STDDR.Read())
        {
            std.Add(STDDR.GetString(0).ToString());
        }
        STDDR.Close();
        con.Close();

        con.Open();
        OracleCommand stdPass = con.CreateCommand();
        stdPass.CommandText = "SELECT s_password FROM STUDENT";
        stdPass.CommandType = CommandType.Text;
        OracleDataReader StdPassDR = stdPass.ExecuteReader();

        while (StdPassDR.Read())
        {
            std.Add(StdPassDR.GetString(0).ToString());
        }
        StdPassDR.Close();
        con.Close();

        if (LoginPortal.LoginAdd || LoginPortal.LoginStd || LoginPortal.LoginTea)
        {
            Login_Pic.Visibility = Visibility.Collapsed;
            Tick.Visibility = Visibility.Visible;
        }
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (adm.Contains(userText.Text.ToString()) && adm.Contains(passText.Password.ToString()))
        {
            LoginPortal.LoginAdd = true;
            LoginPortal.LoginStd = LoginPortal.LoginTea = false;
            LoginPortal.LoginInfo = userText.Text.ToString();
            Login_Pic.Visibility = Visibility.Collapsed;
            Frame.Navigate(typeof(ADMINISTRATORPage));
        }
        else if (std.Contains(userText.Text.ToString()) && std.Contains(passText.Password.ToString()))
        {
            LoginPortal.LoginStd = true;
            LoginPortal.LoginAdd = LoginPortal.LoginTea = false;
            LoginPortal.LoginInfo = userText.Text.ToString();
            Login_Pic.Visibility = Visibility.Collapsed;
            Frame.Navigate(typeof(STUDENTPage));
        }
        else if (tea.Contains(userText.Text.ToString()) && tea.Contains(passText.Password.ToString()))
        {
            LoginPortal.LoginTea = true;
            LoginPortal.LoginStd = LoginPortal.LoginAdd = false;
            LoginPortal.LoginInfo = userText.Text.ToString();
            Login_Pic.Visibility = Visibility.Collapsed;
            Frame.Navigate(typeof(TEACHERPage));
        }
        else
        {
            Error.IsOpen = true;
            Error.RequestedTheme = ElementTheme.Light;
        }
    }
}