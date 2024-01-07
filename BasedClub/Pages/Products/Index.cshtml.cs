using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasedClub.Data;
using BasedClub.Models;

namespace BasedClub.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly BasedClub.Data.BasedContext _context;

        public IndexModel(BasedClub.Data.BasedContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
