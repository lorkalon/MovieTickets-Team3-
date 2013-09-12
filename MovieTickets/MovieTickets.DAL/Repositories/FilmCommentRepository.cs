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
    class FilmCommentRepository : BaseRepository, IFilmCommentRepository
    {
        public FilmCommentRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<FilmComment> GetAll()
        {
            throw new NotImplementedException();
        }

        public FilmComment GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(FilmComment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FilmComment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FilmComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
