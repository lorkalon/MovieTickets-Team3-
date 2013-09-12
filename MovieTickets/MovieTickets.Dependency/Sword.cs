using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Dependency
{
    class Sword : ISword
    {
        public string Kill()
        {
            return "killed";
        }
    }
}
