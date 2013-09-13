using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Repositories;
using MovieTickets.Entities;
using MovieTickets.IDAL;


namespace MovieTickets.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private MovieTickesDBEntities context = new MovieTickesDBEntities();

        public ICinemaRepository GetICinemaRepository()
        {
            return new CinemaRepository(context);
        }

        public ICinemaCommentRepository GetICinemaCommentRepository()
        {
            return new CinemaCommentRepository(context);
        }

        public ICinemaRatingRepository GetICinemaRatingRepository()
        {
            return new CinemaRatingRepository(context);
        }

        public IFilmRepository GetIFilmRepository()
        {
            return new FilmRepository(context);
        }

        public IFilmCommentRepository GetIFilmCommentRepository()
        {
            return new FilmCommentRepository(context);
        }

        public IFilmRatingRepository GetIFilmRatingRepository()
        {
            return new FilmRatingRepository(context);
        }

        public IHallRepository GetIHallRepository()
        {
            return new HallRepository(context);
        }

        public IRoleRepository GetIRoleRepository()
        {
            return new RoleRepository(context);
        }

        public ISeatRepository GetISeatRepository()
        {
            return new SeatRepository(context);
        }

        public ISessionRepository GetISessionRepository()
        {
            return new SessionRepository(context);
        }

        public ITicketReserveRepository GetITicketReserveRepository()
        {
            return new TicketReserveRepository(context);
        }

        public IUserRepository GetIUserRepository()
        {
            return new UserRepository(context);
        }

        public IAuthenticationRepository GetIAuthenticationRepository()
        {
            return new AuthenticationRepository(context);
        }

        public IUsersToRoleRepository GetIUsersToRoleRepository()
        {
            return new UsersToRoleRepository(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
