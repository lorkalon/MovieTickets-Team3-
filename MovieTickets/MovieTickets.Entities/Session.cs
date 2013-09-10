using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class Session
    {
        public int? Id { get; set; }
        public DateTime TimeStart { get; set; }
        public int Price { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public virtual ICollection<TicketReserve> TicketReserves { get; set; }
    }
}
