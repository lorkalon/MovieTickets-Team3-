using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.DAL.Model
{
    public class Seat
    {
        public int? Id { get; set; }
        public int Number { get; set; }
        public bool IsVip { get; set; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }
        public int TicketReserveId { get; set; }
        public virtual TicketReserve TicketReserve { get; set; }
    }
}
