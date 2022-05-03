using Api.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Funzioni
{
    public class MeteoRep : IMeteoRep
    {
        public async Task<IEnumerable<Location>> LocationSearch(string citta)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://foreca-weather.p.rapidapi.com/location/search/{citta}?lang=it"),
				Headers =
				{
					{ "X-RapidAPI-Host", "foreca-weather.p.rapidapi.com" },
					{ "X-RapidAPI-Key", "dc331a0b6emsh1f24c26a83f7513p15f781jsn6b03be12b3ac" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<RootLocation>(body).locations;
				return result;
			}
		}

		public async Task<IEnumerable<Forecast>> DailyMeteo(string id)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://foreca-weather.p.rapidapi.com/forecast/daily/{id}?alt=0&tempunit=C&windunit=MS&periods=8&dataset=full"),
				Headers =
				{
					{ "X-RapidAPI-Host", "foreca-weather.p.rapidapi.com" },
					{ "X-RapidAPI-Key", "dc331a0b6emsh1f24c26a83f7513p15f781jsn6b03be12b3ac" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<RootForecast>(body).forecast;
				return result;
			}
		}
	}
}
