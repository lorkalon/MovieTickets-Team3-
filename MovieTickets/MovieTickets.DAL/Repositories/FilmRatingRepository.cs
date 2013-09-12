using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Model;
using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class FilmRatingRepository : BaseRepository, IFilmRatingRepository
    {
        public FilmRatingRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<FilmRating> GetAll()
        {
            throw new NotImplementedException();
        }

        public FilmRating GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(FilmRating entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FilmRating entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FilmRating entity)
        {
            throw new NotImplementedException();
        }
    }
}
