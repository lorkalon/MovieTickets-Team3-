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
    class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(DataBaseContext context) : base(context)
        {
        }

        public IQueryable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
