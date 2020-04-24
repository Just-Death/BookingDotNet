using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserIds { get; set; }
        public string KitchenIds { get; set; }
    }
}
