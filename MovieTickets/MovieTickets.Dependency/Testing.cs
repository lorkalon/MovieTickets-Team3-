using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace MovieTickets.Dependency
{
   public class Testing
    {
        [Inject]
        public ISword sword { get; set; }
    }
}
