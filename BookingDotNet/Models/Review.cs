using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
