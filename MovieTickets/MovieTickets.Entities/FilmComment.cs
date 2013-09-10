using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class FilmComment
    {
        public int? Id { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
