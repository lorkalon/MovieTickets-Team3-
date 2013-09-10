using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class Hall
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public float? VipCoef { get; set; }
        
        public string Schema { get; set; }

        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
