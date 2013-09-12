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
    class TicketReserveRepository : BaseRepository, ITicketReserveRepository
    {
        public TicketReserveRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<TicketReserve> GetAll()
        {
            throw new NotImplementedException();
        }

        public TicketReserve GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TicketReserve entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TicketReserve entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TicketReserve entity)
        {
            throw new NotImplementedException();
        }
    }
}
