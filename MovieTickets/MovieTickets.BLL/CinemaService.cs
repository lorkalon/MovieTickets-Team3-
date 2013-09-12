using MovieTickets.IBLL;
using MovieTickets.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.BLL
{
    public class CinemaService: ICinemaService
    {
        private ICinemaRepository _cinemaRepository;
        public CinemaService(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public IEnumerable<Entities.Cinema> GetAll()
        {
            return _cinemaRepository.GetAll();
        }

        public Entities.Cinema GetById(int id)
        {
            return _cinemaRepository.GetById(id);
        }

        public void Add(Entities.Cinema item)
        {
            _cinemaRepository.Insert(item);
        }

        public void Update(Entities.Cinema item)
        {
            _cinemaRepository.Update(item);
        }

        public void Delete(Entities.Cinema item)
        {
            _cinemaRepository.Delete(item);
        }
    }
}
