using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrimaWebApp.Pages
{
    public class RispostaModel : PageModel
    {
        public string TestoUtente { get; set; }
        public void OnGet(string testo)
        {
            TestoUtente = testo;
        }
        
    }
}
