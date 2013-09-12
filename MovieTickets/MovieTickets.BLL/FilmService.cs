using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IBLL;
using MovieTickets.IDAL;

namespace MovieTickets.BLL
{
    public class FilmService:IFilmService
    {
        private IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public IEnumerable<Entities.Film> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public Entities.Film GetById(int id)
        {
            return _filmRepository.GetById(id);
        }

        public void Add(Entities.Film item)
        {
            _filmRepository.Insert(item);
        }

        public void Update(Entities.Film item)
        {
            _filmRepository.Update(item);
        }

        public void Delete(Entities.Film item)
        {
            _filmRepository.Delete(item);
        }
    }
}
