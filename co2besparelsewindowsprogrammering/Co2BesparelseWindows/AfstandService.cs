using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Co2BesparelseWindows
{
    internal class AfstandService
    {
        public static async Task<Koordinatset?> AdresseTilKoordinater(string key, string adresse)
        {
            string url = $"https://routeplanning.azurewebsites.net/api/GeocodeAddress?code={key}&address={adresse}";
            HttpClient client = new();

            HttpResponseMessage response = await client.GetAsync(url);

            JObject joResponse = JObject.Parse(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var koordinater = joResponse.ToObject<Koordinatset>();
            return koordinater;
        }

        public static async Task<int> AfstandIMeter(string key, Koordinatset startKoordinater, Koordinatset slutKoordinater)
        {
           
            string url = $"https://routeplanning.azurewebsites.net/api/Distance?code={key}";
            HttpClient client = new();

            Rute r = new();
            r.Start = startKoordinater;
            r.End = slutKoordinater;

            HttpContent content = new StringContent(JObject.FromObject(r).ToString());
            
            HttpResponseMessage response = await client.PostAsync(url, content);

            JObject joResponse = JObject.Parse(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                return -1;
            }
            return Convert.ToInt32((int)(joResponse["Meters"] ?? "0"));

        }
    }
}
