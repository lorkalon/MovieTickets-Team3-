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
    class SessionRepository : BaseRepository, ISessionRepository
    {
        public SessionRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<Session> GetAll()
        {
            throw new NotImplementedException();
        }

        public Session GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Session entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Session entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Session entity)
        {
            throw new NotImplementedException();
        }
    }
}
