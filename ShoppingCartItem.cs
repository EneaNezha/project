// ShoppingCartItem.cs
using WebApplication1.Models;

public class ShoppingCartItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}