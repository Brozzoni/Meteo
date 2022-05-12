using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsFinaleMeteo.Data;
using EsFinaleMeteo.Model;
using EsFinaleMeteo.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsFinaleMeteo.Pages
{
    [Authorize]
    public class RisultatoModel : PageModel
    {
        private readonly AppDbContext _context;

        [Inject]
        public IChiamata rep { get; set; }

        public RisultatoModel(IChiamata scrapingRepository, AppDbContext context)
        {
            this.rep = scrapingRepository;
            _context = context;
        }

        [BindProperty]
        public List<DMeteo> ris { get; set; }

        [BindProperty]
        public DCitta citta { get; set; }

        public async Task<IActionResult> OnGetAsync(string ID, string CITTA)
        {
            ris = await rep.DailyMeteo(ID) as List<DMeteo>;
            citta = new DCitta();
            citta.name = CITTA;

            foreach (var item in ris) { _context.DatiMeteo.Add(item); }

            try
            {
                await _context.SaveChangesAsync();
                return Page();
            }
            catch { return NotFound(); }     
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            AddFavourites(id);
            return RedirectToPage("/Preferiti");
        }

        void AddFavourites(int? idCitta)
        {
            if (idCitta != null)
            {
                var UtCitta = new UtCitta()
                {
                    ID = Guid.NewGuid().ToString(),
                    idCit = int.Parse(idCitta.ToString()),
                    idUt = User.Identity.Name
                };

                if (_context.UtentiCitta.Where(p => p.idCit == UtCitta.idCit).FirstOrDefault() != null)
                    return;

                _context.UtentiCitta.Add(UtCitta);
                _context.SaveChangesAsync();
            }
        }
    }
}
