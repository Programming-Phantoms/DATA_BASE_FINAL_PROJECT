using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class VIEW_CLASSPage : Page
{
    public VIEW_CLASSViewModel ViewModel
    {
        get;
    }

    public VIEW_CLASSPage()
    {
        ViewModel = App.GetService<VIEW_CLASSViewModel>();
        InitializeComponent();
    }
}
