using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Model
{
    public class UtCitta
    {
        [Key]
        public string ID { get; set; }
        public string idUt { get; set; }
        public int idCit { get; set; }
    }
}
