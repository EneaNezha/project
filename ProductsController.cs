// ProductsController.cs
using WebApplication1.Models;

public class ProductsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Products
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    // Add other CRUD actions as needed
}


