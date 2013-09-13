using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class CinemaRepository : BaseRepository, ICinemaRepository
    {
        public CinemaRepository(MovieTickesDBEntities context)
            : base(context)
        {
        }

        public IEnumerable<Cinema> GetAll()
        {
            return Context.Cinemas;
        }

        public Cinema GetById(int id)
        {
            return Context.Cinemas.First(x => x.Id == id);
        }

        public void Insert(Cinema entity)
        {
            Context.Cinemas.Add(entity);
        }

        public void Update(Cinema entity)
        {
            Cinema cinema = Context.Cinemas.First(x => x.Id == entity.Id);
            cinema.Name = entity.Name;
            cinema.Description = entity.Description;
            cinema.Address = entity.Address;
        }

        public void Delete(Cinema entity)
        {
            Cinema cinema = Context.Cinemas.First(x => x.Id == entity.Id);
            Context.Cinemas.Remove(cinema);
        }
    }
}
