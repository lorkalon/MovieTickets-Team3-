using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IDAL;
using MovieTickets.Entities;


namespace MovieTickets.DAL.Repositories
{
    class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(MovieTickesDBEntities context)
            : base(context)
        {
        }

        public IEnumerable<Role> GetAll()
        {
            return Context.Roles;
        }

        public Role GetById(int id)
        {
            return Context.Roles.First(x => x.Id == id);
        }

        public void Insert(Role entity)
        {
            Context.Roles.Add(entity);
        }

        public void Update(Role entity)
        {
            Role role = Context.Roles.First(x => x.Id == entity.Id);
            role.Name = entity.Name;
        }

        public void Delete(Role entity)
        {
            Role role = Context.Roles.First(x => x.Id == entity.Id);
            Context.Roles.Remove(role);
        }
    }
}
