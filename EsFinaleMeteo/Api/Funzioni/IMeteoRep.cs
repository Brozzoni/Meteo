using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Funzioni
{
    public interface IMeteoRep
    {
        Task<IEnumerable<Location>> LocationSearch(string citta);
        Task<IEnumerable<Forecast>> DailyMeteo(string id);
    }
}
