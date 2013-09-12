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
    class SeatRepository : BaseRepository, ISeatRepository
    {
        public SeatRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<Seat> GetAll()
        {
            throw new NotImplementedException();
        }

        public Seat GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Seat entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Seat entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Seat entity)
        {
            throw new NotImplementedException();
        }
    }
}
