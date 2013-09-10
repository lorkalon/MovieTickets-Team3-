using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Seat
    {
        public int? Id { get; set; }
        public int Number { get; set; }
        public bool IsVip { get; set; }

        public Hall Hall { get; set; }
    }
}
