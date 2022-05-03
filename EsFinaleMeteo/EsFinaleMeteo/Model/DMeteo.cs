using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Model
{
    public class DMeteo
    {
        [Key]
        public int id { get; set; }
        public DCittà luogo { get; set; }
        public DateTime Data { get; set; }
        public int MinT { get; set; }
        public int MaxT { get; set; }
        public int AvgT { get; set; }
        public int PercP { get; set; }
    }

    public class DCittà
    {
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }
        public string Stato { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
    }
}
