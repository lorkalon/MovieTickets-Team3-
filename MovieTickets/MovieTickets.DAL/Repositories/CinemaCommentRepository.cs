using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.Entities;
using MovieTickets.IDAL;

namespace MovieTickets.DAL.Repositories
{
    class CinemaCommentRepository : BaseRepository, ICinemaCommentRepository
    {
        public CinemaCommentRepository(MovieTickesDBEntities context) : base(context)
        {

        }

        public IEnumerable<CinemaComment> GetAll()
        {
            return Context.CinemaComments;
        }

        public CinemaComment GetById(int id)
        {
            return Context.CinemaComments.First(x => x.Id == id);
        }

        public void Insert(CinemaComment entity)
        {
            Context.CinemaComments.Add(entity);
        }

        public void Update(CinemaComment entity)
        {
            CinemaComment comment = Context.CinemaComments.First(x => x.Id == entity.Id);
            comment.Comment = entity.Comment;
        }

        public void Delete(CinemaComment entity)
        {
            CinemaComment comment = Context.CinemaComments.First(x => x.Id == entity.Id);
            Context.CinemaComments.Remove(comment);
        }
    }
}
