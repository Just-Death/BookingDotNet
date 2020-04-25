using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public IList<MenuRoom> Orders { get; set; }
    }
}
