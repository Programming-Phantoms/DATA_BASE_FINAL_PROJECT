using System.Data;
using DB_FINAL_PROJECT.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Oracle.ManagedDataAccess.Client;

namespace DB_FINAL_PROJECT.Views;

public sealed partial class VIEW_CLASSESPage : Page
{
    OracleConnection con;

    public VIEW_CLASSESViewModel ViewModel
    {
        get;
    }

    public VIEW_CLASSESPage()
    {
        ViewModel = App.GetService<VIEW_CLASSESViewModel>();
        InitializeComponent();

        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = F21_9243; PASSWORD = 1234";
        con = new OracleConnection(conStr);

        AddDataToGrid();
    }

    private void AddDataToGrid()
    {

        List<Data> dataList = new List<Data>();

        con.Open();
        OracleCommand getEmps = con.CreateCommand();
        getEmps.CommandText = "SELECT * FROM STD";
        getEmps.CommandType = CommandType.Text;
        OracleDataReader empDR = getEmps.ExecuteReader();

        while (empDR.Read())
        {
            if (empDR.FieldCount >= 2)
            {
                dataList.Add(new Data { Column1 = empDR.GetString(0), Column2 = empDR.GetString(1) });
            }
        }
        dataGrid.ItemsSource = dataList;
        empDR.Close();
        con.Close();
    }

    public class Data
    {
        public string? Column1
        {
            get; set;
        }
        public string? Column2
        {
            get; set;
        }
    }
}