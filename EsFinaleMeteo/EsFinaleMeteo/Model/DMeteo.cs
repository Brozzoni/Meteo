using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Model
{
    public class RootLocation
    {
        public List<DCitta> locations { get; set; }
    }
    public class DCitta
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string timezone { get; set; }
        public string adminArea { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string state { get; set; }
    }
    public class DMeteo
    {
        [Key]
        public int id { get; set; }
        public string date { get; set; }
        public string symbol { get; set; }
        public string symbolPhrase { get; set; }
        public int maxTemp { get; set; }
        public int minTemp { get; set; }
        public int maxFeelsLikeTemp { get; set; }
        public int minFeelsLikeTemp { get; set; }
        public int maxRelHumidity { get; set; }
        public int minRelHumidity { get; set; }
        public int maxDewPoint { get; set; }
        public int minDewPoint { get; set; }
        public double precipAccum { get; set; }
        public int snowAccum { get; set; }
        public int maxWindSpeed { get; set; }
        public int windDir { get; set; }
        public int maxWindGust { get; set; }
        public int precipProb { get; set; }
        public int cloudiness { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public int sunriseEpoch { get; set; }
        public int sunsetEpoch { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public int moonPhase { get; set; }
        public int uvIndex { get; set; }
        public int minVisibility { get; set; }
        public double pressure { get; set; }
    }
    public class RootForecast
    {
        public List<DMeteo> forecast { get; set; }
    }

    public class MeteoCittà
    {
        [Key]
        public int id { get; set; }
        public int idCitta { get; set; }
        public int idMeteo { get; set; }
    }
}
