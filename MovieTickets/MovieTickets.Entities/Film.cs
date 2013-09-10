using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class Film
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }

        //TODO: 
        //public virtual ICollection<MediaReference> MediaReferences { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<FilmComment> FilmComments { get; set; }
    }
}
