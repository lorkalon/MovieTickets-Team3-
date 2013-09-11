using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IDAL;

namespace MovieTickets.DAL
{
    public class DalTest: IDalTest
    {
        public string GetMessege()
        {
            return "Messege";
        }
    }
}
