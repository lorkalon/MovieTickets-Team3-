using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class TicketReserveRepository : BaseRepository, ITicketReserveRepository
    {
        public TicketReserveRepository(MovieTickesDBEntities context) : base(context)
        {
        }

        public IEnumerable<TicketReserve> GetAll()
        {
            throw new NotImplementedException();
        }

        public TicketReserve GetById(int id)
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
