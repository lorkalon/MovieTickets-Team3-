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
    class CinemaRepository : BaseRepository, ICinemaRepository
    {
        public CinemaRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IQueryable<Cinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cinema GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cinema entity)
        {
            throw new NotImplementedException();
        }
    }
}
