using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDotNet.Models
{
    public class Review
    {
        [Required]
        public int ReviewId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(300)]
        public string Content { get; set; }

        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
