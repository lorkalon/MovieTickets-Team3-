using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Repositories;
using MovieTickets.IDAL;
using MovieTickets.DAL.Model;

namespace MovieTickets.DAL
{
    class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DataBaseContext context = new DataBaseContext();

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

        public IMediaReferenceRepository GetIMediaReferenceRepository()
        {
            throw new NotImplementedException();
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
