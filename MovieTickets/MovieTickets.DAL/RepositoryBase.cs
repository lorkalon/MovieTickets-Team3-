using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DAL.Model;

namespace MovieTickets.DAL
{
    internal abstract class RepositoryBase
    {
        protected DataBaseContext Context { get; private set; }
        internal RepositoryBase(DataBaseContext context)
        {
            Context = context;
        }
    }
}
