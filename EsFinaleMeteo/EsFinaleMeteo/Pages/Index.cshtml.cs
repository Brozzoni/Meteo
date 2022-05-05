using EsFinaleMeteo.Model;
using EsFinaleMeteo.Service;
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
    public class IndexModel : PageModel
    {
        

        public async Task<IActionResult> OnGetAsync(string citta)
        {
            int codice;
            if (citta != null)
                codice = (await rep.LocationSearch(citta) as List<DCitta>).First().id;

            if (citta == null)
                return RedirectToPage("/Error");

            return Page();
        }

        public void OnPost()
        {

        }
    }
}
