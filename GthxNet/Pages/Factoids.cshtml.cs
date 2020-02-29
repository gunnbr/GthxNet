using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GthxNet.Core;
using GthxNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GthxNet.Pages
{
    public class FactoidsModel : PageModel
    {
        private readonly IFactoidData factoidData;

        public IEnumerable<Factoid> Factoids;

        public FactoidsModel(IFactoidData factoidData)
        {
            this.factoidData = factoidData;
        }

        public void OnGet()
        {
            Factoids = factoidData.GetAll();
        }
    }
}
