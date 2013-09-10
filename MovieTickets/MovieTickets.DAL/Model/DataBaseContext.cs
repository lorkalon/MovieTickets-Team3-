using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Model
{
    class DataBaseContext : DbContext
    {

        public DataBaseContext()
            : base("DataBaseContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaRating> CinemaRatings { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmRating> FilmRatings { get; set; }
        public DbSet<FilmComment> FilmComments { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<MediaReference> MediaReferences { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<TicketReserve> TicketReserves { get; set; }
    }
}
