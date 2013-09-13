using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class FilmCommentRepository : BaseRepository, IFilmCommentRepository
    {
        public FilmCommentRepository(MovieTickesDBEntities context) : base(context)
        {
        }

        public IEnumerable<FilmComment> GetAll()
        {
            return Context.FilmComments;
        }

        public FilmComment GetById(int id)
        {
            return Context.FilmComments.First(x => x.Id == id);
        }

        public void Insert(FilmComment entity)
        {
            Context.FilmComments.Add(entity);
        }

        public void Update(FilmComment entity)
        {
            FilmComment comment = Context.FilmComments.First(x => x.Id == entity.Id);
            comment.Comment = entity.Comment;
        }

        public void Delete(FilmComment entity)
        {
            FilmComment comment = Context.FilmComments.First(x => x.Id == entity.Id);
            Context.FilmComments.Remove(comment);
        }
    }
}
