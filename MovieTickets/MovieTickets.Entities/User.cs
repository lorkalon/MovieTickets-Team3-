using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities
{
    public class User
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsConfirmed { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int FilmCommentId { get; set; }
        public virtual FilmComment FilmComment { get; set; }
        public int CinemaCommentId { get; set; }
        public virtual CinemaComment CinemaComment { get; set; }
        public virtual ICollection<TicketReserve> TicketReserves { get; set; }
        public virtual ICollection<FilmRating> FilmRatings { get; set; }
        public virtual ICollection<CinemaRating> CinemaRatings { get; set; }
    }
}
