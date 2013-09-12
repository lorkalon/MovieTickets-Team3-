using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Model;

namespace MovieTickets.DAL.Repositories
{
    internal abstract class BaseRepository : IDisposable
    {
        protected DataBaseContext Context { get; private set; }
        internal BaseRepository(DataBaseContext context)
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
