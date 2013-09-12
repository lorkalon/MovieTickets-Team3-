using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.IDAL
{
    public interface IUnitOfWork
    {
        //add IRepositor|Entity| GetIRepository|Entity| method to get repository for an entity
        IRepositoryUser GetIRepositoryUser();

        void Save();
    }
}
