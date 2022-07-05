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
            string username = Username.Text;
            string server = Server.Text;
            string database = Database.Text;

            // If relevant create multiple methods and a switch method to allow users to select login options
            string connectionString = SqlStringAADInteractive(username, server, database);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                Trace.WriteLine("Connected successfully!");
            }
        }

        private string SqlStringAADInteractive(string username, string server, string database)
        {
            string connectionString = @"Server=" + server +
                "; Authentication = Active Directory Interactive" +
                ";Database=" + database +
                "; User Id = " + username;
            return connectionString;
        }
    }
}
