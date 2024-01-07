using BasedClub.Data;
using BasedClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace BasedClub.Pages;
public class OrderModel : PageModel
{
    private BasedContext context;
    public OrderModel(BasedContext context) =>
    this.context = context;
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; }
    public Product Product { get; set; }
    [BindProperty, Range(1, int.MaxValue, ErrorMessage = "You must order at least one item")]
    public int Quantity { get; set; } = 1;
    [BindProperty, Required, EmailAddress, Display(Name = "Your Email Address")]
    public string OrderEmail { get; set; }
    [BindProperty, Required, Display(Name = "Shipping Address")]
    public string ShippingAddress { get; set; }
    [BindProperty]
    public decimal UnitPrice { get; set; }
    [TempData]
    public string Confirmation { get; set; }
    public async Task OnGetAsync() =>
    Product = await context.Products.FindAsync(Id);


    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            Basket basket = new();
            if (Request.Cookies[nameof(Basket)] is not null)
            {
                basket =
               JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
            }
            basket.Items.Add(new OrderItem
            {
                ProductId = Id,
                UnitPrice = UnitPrice,
                Quantity = Quantity
            });
            var json = JsonSerializer.Serialize(basket);
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append(nameof(Basket), json, cookieOptions);


            return RedirectToPage("/Index");
        }
        Product = await context.Products.FindAsync(Id);
        if (ModelState.IsValid)
        {
            Confirmation = @$"You have ordered {Quantity} x {Product.Name} 
 at a total cost of {Quantity * UnitPrice:c}";
            return RedirectToPage("/OrderSuccess");
        }
        return Page();
    }

}