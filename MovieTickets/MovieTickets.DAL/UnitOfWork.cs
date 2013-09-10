using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IDAL;
using MovieTickets.DAL.Model;

namespace MovieTickets.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private DataBaseContext context = new DataBaseContext();

        public IRepositoryUser GetIRepositoryUser()
        {
            return new RepositoryUser(context);
        }


        public void Save()
        {
            context.SaveChanges();
        }
    }
}
