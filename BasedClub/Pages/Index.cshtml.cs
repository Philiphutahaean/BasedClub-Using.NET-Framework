using BasedClub.Data;
using BasedClub.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace BasedClub.Pages;
public class IndexModel : PageModel
{
    private readonly BasedContext context;
    public IndexModel(BasedContext context) =>
    this.context = context;

    public List<Product> Products { get; set; } = new();
    public async Task OnGetAsync() =>
    Products = await context.Products.ToListAsync();
}
