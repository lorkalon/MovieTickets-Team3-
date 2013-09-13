using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class FilmRatingRepository : BaseRepository, IFilmRatingRepository
    {
        public FilmRatingRepository(MovieTickesDBEntities context) : base(context)
        {
        }

        public IEnumerable<FilmRate> GetAll()
        {
            return Context.FilmRates;
        }

        public FilmRate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(FilmRate entity)
        {
            Context.FilmRates.Add(entity);
        }

        public void Update(FilmRate entity)
        {
            FilmRate rate =
                Context.FilmRates.First(x => (x.UserId == entity.UserId) && (x.FilmId == entity.FilmId));
            rate.Rating = entity.Rating;
        }

        public void Delete(FilmRate entity)
        {
            FilmRate rate =
                Context.FilmRates.First(x => (x.UserId == entity.UserId) && (x.FilmId == entity.FilmId));
            Context.FilmRates.Remove(rate);
        }
    }
}
