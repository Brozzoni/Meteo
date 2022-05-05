using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IndexModel(IChiamata scrapingRepository)
        {
            this.rep = scrapingRepository;
        }

        [BindProperty]
        public string citta { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
