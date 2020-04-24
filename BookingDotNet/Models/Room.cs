using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomQuantity { get; set; }
        public Category category { get; set; }
        public int BookedUserId { get; set; }
    }
}
