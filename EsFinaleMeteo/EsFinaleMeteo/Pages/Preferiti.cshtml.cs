using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsFinaleMeteo.Data;
using EsFinaleMeteo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsFinaleMeteo.Pages
{
    [Authorize]

    public class PreferitiModel : PageModel
    {
        private readonly AppDbContext _context;
        
        public PreferitiModel(AppDbContext context)
        {
            _context = context;
            eleAsso = _context.UtentiCitta.ToList();
            eleCitta = _context.DatiCittà.ToList();
        }

        public List<UtCitta> eleAsso { get; set; }
        public List<UtCitta> eleAssoUtCit { get; set; }
        public List<DCitta> eleCittaUte { get; set; }
        public List<DCitta> eleCitta { get; set; }

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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            return Page();
        }
    }
}
