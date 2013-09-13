using MovieTickets.Entities;
using MovieTickets.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.DAL.Repositories
{
    class AuthenticationRepository : BaseRepository, IAuthenticationRepository
    {
        public AuthenticationRepository(MovieTickesDBEntities context) 
            : base(context)
        {
            
        }

        public IEnumerable<Authentication> GetAll()
        {
            return Context.Authentications;
        }

        public Authentication GetById(int id)
        {
            return Context.Authentications.First(x => x.UserId == id);
        }

        public void Insert(Authentication entity)
        {
            entity.User = Context.Users.First(x => x.Id == entity.UserId);
            Context.Authentications.Add(entity);
        }

        public void Update(Authentication entity)
        {
            Authentication auth = Context.Authentications.First(x => x.UserId == entity.UserId);
            auth.Password = entity.Password;
        }

        public void Delete(Authentication entity)
        {
            Authentication auth = Context.Authentications.First(x => x.UserId == entity.UserId);
            Context.Authentications.Remove(auth);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
