using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjektLIstaZakupow.Models;

namespace ProjektLIstaZakupow.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ProjektLIstaZakupow.Models.MyDbContext _context;

        public DetailsModel(ProjektLIstaZakupow.Models.MyDbContext context)
        {
            _context = context;
        }

      public Produkt Produkt { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produkty == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkty.FirstOrDefaultAsync(m => m.Id == id);
            if (produkt == null)
            {
                return NotFound();
            }
            else 
            {
                Produkt = produkt;
            }
            return Page();
        }
    }
}
