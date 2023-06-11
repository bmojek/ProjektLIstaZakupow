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
    public class IndexModel : PageModel
    {
        private readonly ProjektLIstaZakupow.Models.MyDbContext _context;

        public IndexModel(ProjektLIstaZakupow.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Produkt> Produkt { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produkty != null)
            {
                Produkt = await _context.Produkty.ToListAsync();
            }
        }
    }
}