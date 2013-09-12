using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Model;
using MovieTickets.Entities;
using MovieTickets.IDAL;

namespace MovieTickets.DAL.Repositories
{
    class CinemaCommentRepository : BaseRepository, ICinemaCommentRepository
    {
        public CinemaCommentRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<CinemaComment> GetAll()
        {
            throw new NotImplementedException();
        }

        public CinemaComment GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CinemaComment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CinemaComment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CinemaComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
