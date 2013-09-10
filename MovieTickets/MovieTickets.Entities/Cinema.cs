using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class Cinema
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        //TODO:
        //public virtual ICollection<MediaReference> MediaReferences { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<CinemaComment> CinemaComments { get; set; }
    }
}
