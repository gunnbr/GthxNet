using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GthxNet.Core;
using GthxNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GthxNet
{
    public class AdminFactoidsModel : PageModel
    {
        private readonly IFactoidData factoidData;

        public IEnumerable<Factoid> Factoids { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public AdminFactoidsModel(IFactoidData factoidData)
        {
            this.factoidData = factoidData;
        }

        public void OnGet()
        {
            Factoids = factoidData.GetFactoidsByName(SearchTerm);
        }
    }
}