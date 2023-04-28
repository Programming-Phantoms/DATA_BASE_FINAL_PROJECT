using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class VIEW_CLASSESPage : Page
{
    public VIEW_CLASSESViewModel ViewModel
    {
        get;
    }

    public VIEW_CLASSESPage()
    {
        ViewModel = App.GetService<VIEW_CLASSESViewModel>();
        InitializeComponent();
    }
}
