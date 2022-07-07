using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;

namespace FormueConnect
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class TableWindow : Window
    {

        private SqlConnection SqlConn;
        public TableWindow(SqlConnection SqlConnection)
        {
            InitializeComponent();
            SqlConn = SqlConnection;
            NameFetcher();
        }

        private void NameFetcher()
        {
            string queryString = $@"SELECT TABLE_NAME
                                FROM INFORMATION_SCHEMA.TABLES
                                WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='{SqlConn.Database}'";

            SqlCommand command = new SqlCommand(queryString, SqlConn);
            SqlDataReader reader = command.ExecuteReader();

            List<string> tableNames = new();
            while (reader.Read())
            {
                tableNames.Add(reader.GetString("TABLE_NAME"));
            }
            lbTableNames.ItemsSource = tableNames;
        }

        private void Print(object sender, SelectionChangedEventArgs args)
        {
            Trace.WriteLine("Its alive!!!");
        }

    }
}
