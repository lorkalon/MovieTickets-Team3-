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
    class HallRepository : BaseRepository, IHallRepository
    {
        public HallRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<Hall> GetAll()
        {
            throw new NotImplementedException();
        }

        public Hall GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Hall entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Hall entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Hall entity)
        {
            throw new NotImplementedException();
        }
    }
}
