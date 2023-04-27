using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class ADMINISTRATORPage : Page
{
    public ADMINISTRATORViewModel ViewModel
    {
        get;
    }

    public ADMINISTRATORPage()
    {
        ViewModel = App.GetService<ADMINISTRATORViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);

        if (e.Parameter != null)
        {
            OutputTextBlock.Text = e.Parameter.ToString();
        }
    }
}
