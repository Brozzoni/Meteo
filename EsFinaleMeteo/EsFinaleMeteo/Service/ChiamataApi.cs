using EsFinaleMeteo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Service
{
    public class ChiamataApi : IChiamata
    {
        private readonly HttpClient httpClient;
        public ChiamataApi(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<DCitta>> LocationSearch(string citta)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<DCitta>>($"MetControllers/LocationSearch/{citta}");
        }

        public async Task<IEnumerable<DMeteo>> DailyMeteo(string codice)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<DMeteo>>(@$"MetControllers/DailyMeteo/{codice}");
        }
    }
}
