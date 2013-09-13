using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IDAL;
using MovieTickets.Entities;


namespace MovieTickets.DAL.Repositories
{
    class CinemaRatingRepository : BaseRepository, ICinemaRatingRepository
    {
        public CinemaRatingRepository(MovieTickesDBEntities context)
            : base(context)
        {
        }

        public IEnumerable<CinemaRate> GetAll()
        {
            return Context.CinemaRates;
        }

        public CinemaRate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CinemaRate entity)
        {
            Context.CinemaRates.Add(entity);
        }

        public void Update(CinemaRate entity)
        {
            CinemaRate rate = 
                Context.CinemaRates.First(x => (x.UserId == entity.UserId) && (x.CinemaId == entity.CinemaId));
            rate.Rating = entity.Rating;
        }

        public void Delete(CinemaRate entity)
        {
            CinemaRate rate =
                Context.CinemaRates.First(x => (x.UserId == entity.UserId) && (x.CinemaId == entity.CinemaId));
            Context.CinemaRates.Remove(rate);
        }
    }
}
