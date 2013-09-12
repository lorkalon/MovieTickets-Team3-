using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;

namespace MovieTickets.IDAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

    //Write there IRepository|Entity| interfaces with necessary methods

    public interface ICinemaRepository : IRepository<Cinema>
    {

    }

    public interface ICinemaCommentRepository : IRepository<CinemaComment>
    {

    }

    public interface ICinemaRatingRepository : IRepository<CinemaRating>
    {

    }

    public interface IFilmRepository : IRepository<Film>
    {

    }

    public interface IFilmCommentRepository : IRepository<FilmComment>
    {

    }

    public interface IFilmRatingRepository : IRepository<FilmRating>
    {

    }

    public interface IHallRepository : IRepository<Hall>
    {

    }

    public interface IMediaReferenceRepository : IRepository<MediaReference>
    {

    }

    public interface IRoleRepository : IRepository<Role>
    {

    }

    public interface ISeatRepository : IRepository<Seat>
    {

    }

    public interface ISessionRepository : IRepository<Session>
    {

    }

    public interface ITicketReserveRepository : IRepository<TicketReserve>
    {

    }

    public interface IUserRepository : IRepository<User>
    {

    }
}
