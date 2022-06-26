using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Kortspil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Kortene er hentet fra https://acbl.mybigcommerce.com/52-playing-cards/
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kortnummer = Convert.ToInt32(Kort.Text);
            string filnavn = FindBillede(kortnummer);
            string url = $"/Billeder/{filnavn}";
            Uri uri = new (url, UriKind.Relative);
            BitmapImage image = new(uri);
           
            Billede.Source = image;
            
        }

        private string FindBillede(int kortnummer)
        {
            // bestem kortets kulør
            string[] possible_colors = new string[4] {"Spar", "Ruder", "Klør", "Hjerter"};
            string card_color = possible_colors[(kortnummer - 1 )/ 13];

            // bestem kortets værdi
            string? card_value = null;
            int remainder = kortnummer % 13;
            switch(remainder)
            {
                case 0:
                    card_value = "Konge";
                    break;
                case 1:
                    card_value = "Es";
                    break;
                case 11:
                    card_value = "Knægt";
                    break;
                case 12:
                    card_value = "Dame";
                    break;
                default:
                    card_value = remainder.ToString();
                    break;
            }   

            return $"{card_value}-{card_color}.jpg";
        }
    }
}
