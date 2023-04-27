using DB_FINAL_PROJECT.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Devices.Enumeration;

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
        if (userText.Text == "bilal" && passText.Password == "1234")
        {
            mainText.Text = """Loged in successfully! 🎉""";
            Frame.Navigate(typeof(ADMINISTRATORPage), "Welcome " + userText.Text);
        }
        else
        {
            mainText.Text = "Login into your account!";
        }
    }
}
