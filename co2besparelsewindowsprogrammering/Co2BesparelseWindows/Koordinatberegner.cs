using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co2BesparelseWindows
{
    /// <summary>
    /// Oversætter en adresse til GPS-koordinater
    /// </summary>
    internal class Koordinatberegner
    {
        private string key;

        /// <summary>
        /// Initialiserer objektet
        /// </summary>
        /// <param name="key">Den nøgle der skal bruges til at kalde servicen</param>
        public Koordinatberegner(string key)
        {
            this.key = key;
        }

        /// <summary>
        /// 
        /// Konverterer en adresse til et sæt GPS-koordinater
        /// </summary>
        /// <param name="adresse">Den adresse, der skal konverteres (fx Nansensgade 19 København)</param>
        /// <returns>Adressens koordinatsæt som et objekt af typen Koordinatset</returns>
        public async Task<Koordinatset> HentKoordinaterForAdresse(string adresse)
        {
            return await AfstandService.AdresseTilKoordinater(key, adresse);            
        }
    }
}
