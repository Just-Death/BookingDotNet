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
        //One-to-Many
        public Category Category { get; set; }

        //One-to-Many
        public ICollection<Review> Reviews { get; set; }

        //One-to-One
        public int BookedUserId { get; set; }
        public User User { get; set; }

        //Many-to-Many
        public IList<MenuRoom> Orders { get; set; }
    }
}
