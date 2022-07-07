using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;

namespace FormueConnect
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void LoginClick(object sender, RoutedEventArgs e)
        {
            // User data from UI fields

            Dictionary<string, string> credentials = new()
            {
                ["username"] = Username.Text,
                ["server"] = Server.Text,
                ["database"] = Database.Text
            };

        // If relevant create multiple methods and a switch method to allow users to select login options
        string connectionString = SqlStringAADInteractive(credentials);

            using (SqlConnection SqlConnection = new SqlConnection(connectionString))
            {
                await SqlConnection.OpenAsync();
                Trace.WriteLine("Connected successfully!");
                TableWindow tableWindow = new(SqlConnection, credentials);
                this.Close();
                tableWindow.Show();
            }
        }

        private string SqlStringAADInteractive(Dictionary<string,string> credentials)
        {
            string connectionString = @"Server=" + credentials["server"] +
                ";Authentication = Active Directory Interactive" +
                ";Database=" + credentials["database"] +
                ";User Id=" + credentials["username"];

            return connectionString;
        }
    }
}
