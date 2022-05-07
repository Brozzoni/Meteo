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
   [Authorize]

    public class IndexModel : PageModel
    {
        [Inject]
        public IChiamata rep { get; set; }

        public IndexModel(IChiamata scrapingRepository)
        {
            this.rep = scrapingRepository;
        }

        [BindProperty]
        public DCitta citta { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cerca = await rep.LocationSearch(citta.name);
            return RedirectToPage("/Risultato", new { ID = cerca.First().id });          
        }
    }
}
