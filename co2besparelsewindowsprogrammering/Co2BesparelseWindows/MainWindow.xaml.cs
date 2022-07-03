using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Co2BesparelseWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Beregn_Click(object sender, RoutedEventArgs e)
        {
            // Disse variabler indeholder de adresser brugeren taster ind, 
            // og angiver den valgte transportform
            string startadresse = Hjem.Text;
            string slutadresse = Arbejde.Text;
            bool benzinBil = Benzin.IsChecked ?? false;
            bool dieselBil = Diesel.IsChecked ?? false;
            bool tog = Tog.IsChecked ?? false;

            // Skriv din kode her. Start med at indsætte nøgleværdierne
            // fra opgaven
            var koordinatNogle = "";
            var afstandNogle = "";


            Koordinatberegner koordinatberegner = new(koordinatNogle);
            Afstandsberegner afstandsberegner = new(afstandNogle);
            Koordinatset koordinat_home = await koordinatberegner.HentKoordinaterForAdresse(startadresse);
            Koordinatset koordinat_away = await koordinatberegner.HentKoordinaterForAdresse(slutadresse);
            float afstand_response = await afstandsberegner.BeregnAfstandIMeter(koordinat_home, koordinat_away);

            float co2_saving;
            if (benzinBil) co2_saving = 174 * afstand_response / 1000000;
            else if (dieselBil) co2_saving = 168 * afstand_response / 1000000;
            else if (tog) co2_saving = 36 * afstand_response / 1000000;
            else co2_saving = 0;
            MessageBox.Show($"Du kan spare {co2_saving} kg CO2 ved ikke at foretage den rejse", "Besparelse");
        }
    }
}
