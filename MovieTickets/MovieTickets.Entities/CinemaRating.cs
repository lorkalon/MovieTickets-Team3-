using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class CinemaRating
    {
        public double Rating { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
