using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsFinaleMeteo.Data;
using EsFinaleMeteo.Model;
using EsFinaleMeteo.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsFinaleMeteo.Pages
{
    public class RisultatoPreferitiModel : PageModel
    {
        private readonly AppDbContext _context;

        [Inject]
        public IChiamata rep { get; set; }

        public RisultatoPreferitiModel(IChiamata scrapingRepository, AppDbContext context)
        {
            this.rep = scrapingRepository;
            _context = context;
            eleAsso = _context.UtentiCitta.ToList();
            eleCitta = _context.DatiCittà.ToList();
            ris = new List<DMeteo>();
        }

        public List<UtCitta> eleAsso { get; set; }
        public List<UtCitta> eleAssoUtCit { get; set; }
        public List<DCitta> eleCittaUte { get; set; }
        public List<DCitta> eleCitta { get; set; }
        public List<DMeteo> ris { get; set; }
        public DCitta citta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ris = new List<DMeteo>();
            ris = await rep.DailyMeteo(id.ToString()) as List<DMeteo>;
            citta = new DCitta();
            //citta.name = CITTA;

            return Page();
        }
    }
}
