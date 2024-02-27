using WebApplication1.Models;

public class CheckoutController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public CheckoutController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public IActionResult Review()
    {
        var userId = _userManager.GetUserId(User);
        var shoppingCartItems = _context.ShoppingCartItems
            .Include(item => item.Product)
            .Where(item => item.UserId == userId)
            .ToList();

        return View(shoppingCartItems);
    }

    public IActionResult ShippingDetails()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Payment()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult CompleteOrder()
    {
        return RedirectToAction("Index", "Home");
    }
    [HttpPost]
    public IActionResult Payment(ShippingDetailsViewModel shippingDetails)
    {
        if (!ModelState.IsValid)
        {
            return View("ShippingDetails", shippingDetails);
        }

        return View("PaymentConfirmation");
    }
}
