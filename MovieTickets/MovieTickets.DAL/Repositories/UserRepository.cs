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
    class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
