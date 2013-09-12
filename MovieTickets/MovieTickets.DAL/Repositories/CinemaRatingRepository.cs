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
    class CinemaRatingRepository : BaseRepository, ICinemaRatingRepository
    {
        public CinemaRatingRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IQueryable<CinemaRating> GetAll()
        {
            throw new NotImplementedException();
        }

        public CinemaRating GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CinemaRating entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CinemaRating entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CinemaRating entity)
        {
            throw new NotImplementedException();
        }
    }
}
