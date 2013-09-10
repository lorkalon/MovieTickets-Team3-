using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Session
    {
        public int? Id { get; set; }
        public DateTime TimeStart { get; set; }

        public Film Film { get; set; }
        public Hall Hall { get; set; }
        public virtual ICollection<TicketReserve> TicketReserves { get; set; }
    }
}
