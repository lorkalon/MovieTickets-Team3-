using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class TicketReserve
    {
        public int? Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
    }
}
