using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TicketReserve
    {
        public int? Id { get; set; }

        public User User { get; set; }
        public Seat Seat { get; set; }
        public Session Session { get; set; }
    }
}
