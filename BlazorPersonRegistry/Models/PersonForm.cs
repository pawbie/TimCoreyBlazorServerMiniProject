using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BlazorPersonRegistry.Models
{
    public class PersonForm
    {
        [Display(Name = "First Name")]
        [Required]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string? LastName { get; set; }

        [Display(Name = "Age")]
        [Required]
        public int? Age { get; set; }
    }
}
