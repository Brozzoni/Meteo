using Api.Funzioni;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MetControllers : ControllerBase
    {
        private readonly IMeteoRep meteoRep;
        public MetControllers(IMeteoRep meteoRep)
        {
            this.meteoRep = meteoRep;
        }

        [HttpGet("LocationSearch/{citta}")]
        public async Task<IEnumerable<Location>> LocationSearch(string citta)
        {
            List<Location> eleMeteo = new List<Location>();
            eleMeteo = await meteoRep.LocationSearch(citta) as List<Location>;
            return eleMeteo;
        }

        [HttpGet("DailyMeteo/{id}")]
        public async Task<IEnumerable<Forecast>> DailyMeteo(string id)
        {
            List<Forecast> eleMeteo = new List<Forecast>();
            eleMeteo = await meteoRep.DailyMeteo(id) as List<Forecast>;
            return eleMeteo;
        }
    }
}
