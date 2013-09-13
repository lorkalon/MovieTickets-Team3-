using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;


namespace MovieTickets.DAL.Repositories
{
    class HallRepository : BaseRepository, IHallRepository
    {
        public HallRepository(MovieTickesDBEntities context)
            : base(context)
        {
        }

        public IEnumerable<Hall> GetAll()
        {
            return Context.Halls;
        }

        public Hall GetById(int id)
        {
            return Context.Halls.First(x => x.Id == id);
        }

        public void Insert(Hall entity)
        {
            Context.Halls.Add(entity);
        }

        public void Update(Hall entity)
        {
            Hall hall = Context.Halls.First(x => entity.Id == x.Id);
            hall.Schema = entity.Schema;
            hall.VipCoef = entity.VipCoef;
            hall.Description = entity.Description;
        }

        public void Delete(Hall entity)
        {
            Hall hall = Context.Halls.First(x => x.Id == entity.Id);
            Context.Halls.Remove(hall);
        }
    }
}
