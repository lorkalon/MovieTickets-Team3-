using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hall
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public float? VipCoef { get; set; }

        public Cinema Cinema { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
