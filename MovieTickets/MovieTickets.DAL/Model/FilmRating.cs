using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.DAL.Model
{
    public class FilmRating
    {
        public double Rating { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
