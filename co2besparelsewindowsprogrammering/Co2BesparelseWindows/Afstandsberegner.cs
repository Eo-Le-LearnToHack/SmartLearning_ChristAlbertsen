using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co2BesparelseWindows
{
    internal class Afstandsberegner
    {

        private readonly string key;

        /// <summary>
        /// Initialiserer objektet og angiver den nøgle, der skal bruges for at
        /// tilgå afstandsberegningen.
        /// </summary>
        /// <param name="key">Nøglen til afstandsberegningen</param>
        public Afstandsberegner(string key)
        {
            this.key = key;
        }

        /// <summary>
        /// Beregner afstanden mellem to set GPS-koordinater og returnerer
        /// afstanden imellem dem i meter.
        /// </summary>
        /// <param name="start">Startadressens koordinater</param>
        /// <param name="slut">Slutadressens koordinater</param>
        /// <returns>Afstanden i meter</returns>
        public async Task<int> BeregnAfstandIMeter(Koordinatset start, Koordinatset slut)
        {
            return await AfstandService.AfstandIMeter(key, start, slut);
        }
    }
}
