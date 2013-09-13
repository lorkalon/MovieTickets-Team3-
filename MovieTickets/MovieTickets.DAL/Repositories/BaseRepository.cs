using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieTickets.Entities;

namespace MovieTickets.DAL.Repositories
{
    internal abstract class BaseRepository : IDisposable
    {
        protected MovieTickesDBEntities Context { get; private set; }
        internal BaseRepository(MovieTickesDBEntities context)
        {
            Context = context;
        }

        public void Save()
        {
            Context.SaveChanges();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
