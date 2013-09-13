using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.IDAL;
using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    class FilmRepository : BaseRepository, IFilmRepository
    {
        public FilmRepository(MovieTickesDBEntities context) : base(context)
        {
        }

        public IEnumerable<Film> GetAll()
        {
            return Context.Films;
        }

        public Film GetById(int id)
        {
            return Context.Films.First(x => x.Id == id);
        }

        public void Insert(Film entity)
        {
            Context.Films.Add(entity);
        }

        public void Update(Film entity)
        {
            Film film = Context.Films.First(x => x.Id == entity.Id);
            film.Title = entity.Title;
            film.Description = entity.Description;
        }

        public void Delete(Film entity)
        {
            Film film = Context.Films.First(x => x.Id == entity.Id);
            Context.Films.Remove(film);
        }
    }
}
