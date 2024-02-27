namespace WebApplication1.Models
{
    public class ShippingDetailsViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        
    }

}
