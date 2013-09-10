using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CinemaRating
    {
        public double Rating { get; set; }

        public User User { get; set; }
        public Cinema Cinema { get; set; }
    }
}
