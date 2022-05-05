using EsFinaleMeteo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Service
{
    public interface IChiamata
    {
        Task<IEnumerable<DCitta>> LocationSearch(string citta);
        Task<IEnumerable<DMeteo>> DailyMeteo(string codice);
    }
}
