using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjektLIstaZakupow.Models;

namespace ProjektLIstaZakupow.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ProjektLIstaZakupow.Models.MyDbContext _context;

        public CreateModel(ProjektLIstaZakupow.Models.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produkt Produkt { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produkty == null || Produkt == null)
            {
                return Page();
            }

            _context.Produkty.Add(Produkt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
