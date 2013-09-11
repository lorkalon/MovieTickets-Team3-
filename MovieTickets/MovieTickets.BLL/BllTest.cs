using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.IBLL;
using MovieTickets.IDAL;

namespace MovieTickets.BLL
{
    public class BllTest:IBllTest
    {
        private IDalTest _daltest;

        public BllTest(IDalTest dalTest)
        {
            _daltest = dalTest;
        }

        public string GetDallString()
        {
            return _daltest.GetMessege();
        }
    }
}
