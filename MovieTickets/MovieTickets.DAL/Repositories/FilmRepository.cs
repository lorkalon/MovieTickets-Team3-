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
    class FilmRepository : BaseRepository, IFilmRepository
    {
        public FilmRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<Film> GetAll()
        {
            throw new NotImplementedException();
        }

        public Film GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Film entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Film entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
