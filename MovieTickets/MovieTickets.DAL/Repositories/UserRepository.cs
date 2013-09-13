using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IDAL;
using MovieTickets.Entities;


namespace MovieTickets.DAL.Repositories
{
    class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(MovieTickesDBEntities context)
            : base(context)
        {
        }

        public IEnumerable<User> GetAll()
        {
            return Context.Users;
        }

        public User GetById(int id)
        {
            return Context.Users.First(x => x.Id == id);  // FirstOrDefault???
        }

        public void Insert(User entity)
        {
            Context.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = Context.Users.First(x => x.Id == entity.Id);  // FirstOrDefault???
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Email = entity.Email;
            user.Login = entity.Login;
            user.Blocked = entity.Blocked;
        }

        public void Delete(User entity)
        {
            User user = Context.Users.First(x => x.Id == entity.Id);
            Context.Users.Remove(user);
        }

        public User GetByEmail(string email)  // ??
        {
            //---------------
            return null;
        }
    }
}
