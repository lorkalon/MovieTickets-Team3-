using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FilmRating
    {
        public double Rating { get; set; }

        public User User { get; set; }
        public Film Film { get; set; }
    }
}
