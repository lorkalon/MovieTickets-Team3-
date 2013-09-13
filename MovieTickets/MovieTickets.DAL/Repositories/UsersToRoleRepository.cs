using MovieTickets.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.DAL.Repositories
{
    class UsersToRoleRepository : BaseRepository, IUsersToRoleRepository
    {
        public UsersToRoleRepository(MovieTickets.Entities.MovieTickesDBEntities context) 
            : base(context)
        {
            
        }

        public IEnumerable<Entities.UsersToRole> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entities.UsersToRole GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entities.UsersToRole entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.UsersToRole entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.UsersToRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
