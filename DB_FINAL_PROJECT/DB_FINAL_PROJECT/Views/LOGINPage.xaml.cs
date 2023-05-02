using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Devices.Enumeration;
using static DB_FINAL_PROJECT.App;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class LOGINPage : Page
{
    public LOGINViewModel ViewModel
    {
        get;
    }

    public LOGINPage()
    {
        ViewModel = App.GetService<LOGINViewModel>();
        InitializeComponent();
        OnLoad();
    }

    private void OnLoad()
    {
        if(LoginPortal.LoginAdd || LoginPortal.LoginStd || LoginPortal.LoginTea)
        {
            Login_Pic.Visibility = Visibility.Collapsed;
            Tick.Visibility = Visibility.Visible;
        }
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (userText.Text == "A" && passText.Password == "1234")
        {
            LoginPortal.LoginAdd = true;
            LoginPortal.LoginStd = LoginPortal.LoginTea = false;
            Login_Pic.Visibility = Visibility.Collapsed;
            Tick.Visibility = Visibility.Visible;
            Frame.Navigate(typeof(ADMINISTRATORPage));
        }
        else if (userText.Text == "S" && passText.Password == "1234")
        {
            LoginPortal.LoginStd = true;
            LoginPortal.LoginAdd = LoginPortal.LoginTea = false;
            Login_Pic.Visibility = Visibility.Collapsed;
            Tick.Visibility = Visibility.Visible;
            Frame.Navigate(typeof(STUDENTPage));
        }
        else if (userText.Text == "T" && passText.Password == "1234")
        {
            LoginPortal.LoginTea = true;
            LoginPortal.LoginStd = LoginPortal.LoginAdd = false;
            Login_Pic.Visibility = Visibility.Collapsed;
            Tick.Visibility = Visibility.Visible;
            Frame.Navigate(typeof(TEACHERPage));
        }
    }
}
