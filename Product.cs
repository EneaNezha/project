namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StartWithCharacter(ErrorMessage = "Product name must start with a character, not a number.")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }