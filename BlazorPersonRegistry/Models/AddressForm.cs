using System.ComponentModel.DataAnnotations;

namespace BlazorPersonRegistry.Models
{
    public class AddressForm
    {
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
    }
}
