using System;
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

    public class PreferitiModel : PageModel
    {
        private readonly AppDbContext _context;

        [Inject]
        public IChiamata rep { get; set; }

        public PreferitiModel(IChiamata scrapingRepository, AppDbContext context)
        {
            this.rep = scrapingRepository;
            _context = context;
            eleAsso = _context.UtentiCitta.ToList();
            eleCitta = _context.DatiCittà.ToList();
        }

        public List<UtCitta> eleAsso { get; set; }
        public List<UtCitta> eleAssoUtCit { get; set; }
        public List<DCitta> eleCittaUte { get; set; }
        public List<DCitta> eleCitta { get; set; }

        [BindProperty]
        public DCitta citta { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            eleCittaUte = new List<DCitta>();
            eleAssoUtCit = eleAsso.Where(p=>p.idUt == User.Identity.Name).ToList();

            foreach (var item in eleAssoUtCit)
            {
                var z = eleCitta.Where(p => p.id == item.idCit).FirstOrDefault();

                if (z != null)
                    eleCittaUte.Add(z);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id, string cit)
        {
            string buttonClicked = Request.Form["SubmitButton"];

            if (buttonClicked == "search")
            {
                //citta.name = cit;
                var cerca = await rep.DailyMeteo(id.ToString());
                return RedirectToPage("/RisultatoPreferiti", new { risultato = cerca.First(), CITTA = citta.name });
            }

            if (buttonClicked == "delete")
            {
                var z = _context.DatiCittà.FirstOrDefault(p => p.id == id);
                var ass = _context.UtentiCitta.FirstOrDefault(p => p.idCit == id);

                _context.DatiCittà.Remove(z);
                _context.UtentiCitta.Remove(ass);

                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToPage("/Index");
                }
                catch
                {
                    return RedirectToPage("/Error");
                }
            }
            return Page();
        }
    }
}
