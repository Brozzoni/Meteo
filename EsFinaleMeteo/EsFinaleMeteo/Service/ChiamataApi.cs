using EsFinaleMeteo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Service
{
    public class ChiamataApi
    {
        public async Task<IEnumerable<DCitta>> LocationSearch(string citta)
        {
            HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer");

            return await httpClient.GetFromJsonAsync<IEnumerable<DCitta>>(@$"LocationSearch/{citta}");
        }

        public async Task<IEnumerable<DMeteo>> DailyMeteo(string codice)
        {
            HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer");

            return await httpClient.GetFromJsonAsync<IEnumerable<DMeteo>>(@$"DailyMeteo/{codice}");
        }
    }
}
