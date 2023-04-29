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
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (userText.Text == "A" && passText.Password == "1234")
        {
            mainText.Text = """Loged in successfully! 🎉""";
            LoginPortal.LoginAdd = true;
        }
        else if (userText.Text == "S" && passText.Password == "1234")
        {
            mainText.Text = """Loged in successfully! 🎉""";
            LoginPortal.LoginStd = true;
        }
        else if (userText.Text == "T" && passText.Password == "1234")
        {
            mainText.Text = """Loged in successfully! 🎉""";
            LoginPortal.LoginTea = true;
        }
    }
}
