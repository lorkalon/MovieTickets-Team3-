using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.DAL.Model
{
    public class CinemaComment
    {
        public int? Id { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
