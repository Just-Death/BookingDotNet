using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Menu
    {
        [Required]
        public int MenuId { get; set; }

        [Required(ErrorMessage = "Please enter name of dish")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public IList<MenuRoom> Orders { get; set; }
    }
}
