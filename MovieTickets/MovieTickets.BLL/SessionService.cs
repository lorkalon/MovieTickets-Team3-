using MovieTickets.IBLL;
using MovieTickets.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.BLL
{
    public class SessionService : ISessionService
    {
        private ISessionRepository _sessionRepository;

        public SessionService(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public IEnumerable<Entities.Session> GetAll()
        {
            return _sessionRepository.GetAll();
        }

        public Entities.Session GetById(int id)
        {
            return _sessionRepository.GetById(id);
        }

        public void Add(Entities.Session item)
        {
            _sessionRepository.Insert(item);
        }

        public void Update(Entities.Session item)
        {
            _sessionRepository.Update(item);
        }

        public void Delete(Entities.Session item)
        {
            _sessionRepository.Delete(item);
        }

        private bool _isDisposed = false;
        private void DoDispose(bool suppressFinilize)
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                _sessionRepository.Dispose();
                if (suppressFinilize)
                {
                    GC.SuppressFinalize(this);
                }
            }
        }

        public void Dispose()
        {
            DoDispose(true);
        }

        ~SessionService()
        {
            DoDispose(false);
        }
    }
}
