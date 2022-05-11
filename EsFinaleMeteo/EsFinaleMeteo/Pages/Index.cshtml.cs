using EsFinaleMeteo.Data;
using EsFinaleMeteo.Model;
using EsFinaleMeteo.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Pages
{
    //[Authorize]

    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        [Inject]
        public IChiamata rep { get; set; }

        public IndexModel(IChiamata scrapingRepository, AppDbContext context)
        {
            this.rep = scrapingRepository;
            _context = context;
        }

        [BindProperty]
        public DCitta citta { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cerca = await rep.LocationSearch(citta.name);
            return RedirectToPage("/Risultato", new { ID = cerca.First().id, CITTA = cerca.First().name });

        }

    }

}
