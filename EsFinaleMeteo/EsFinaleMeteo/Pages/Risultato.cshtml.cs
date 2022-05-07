using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsFinaleMeteo.Model;
using EsFinaleMeteo.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsFinaleMeteo.Pages
{
    public class RisultatoModel : PageModel
    {
        [Inject]
        public IChiamata rep { get; set; }

        public RisultatoModel(IChiamata scrapingRepository)
        {
            this.rep = scrapingRepository;
        }

        [BindProperty]
        public List<DMeteo> ris { get; set; }

        [BindProperty]
        public decimal avg { get; set; }

        public async Task<IActionResult> OnGetAsync(string ID)
        {
            ris = await rep.DailyMeteo(ID) as List<DMeteo>;
            return Page();
        }

        public void OnPost()
        {

        }
    }
}
