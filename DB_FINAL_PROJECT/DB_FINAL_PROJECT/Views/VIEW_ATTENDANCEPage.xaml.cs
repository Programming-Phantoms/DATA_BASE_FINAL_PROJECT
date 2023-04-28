using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class VIEW_ATTENDANCEPage : Page
{
    public VIEW_ATTENDANCEViewModel ViewModel
    {
        get;
    }

    public VIEW_ATTENDANCEPage()
    {
        ViewModel = App.GetService<VIEW_ATTENDANCEViewModel>();
        InitializeComponent();
    }
}
