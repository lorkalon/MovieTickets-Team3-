using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;

namespace MovieTickets.IBLL
{
    public interface IAccountService
    {
        bool CreateNewUser(User user, Authentication authentication, ConfirmRegistrationKeys registrationKeys);
       
        User GetUserProfile(string email);
        Authentication GetUserPrivateData(string email);

        bool UpdateUserProfile(User user);
        bool UpdateUserPrivateData(Authentication data);

        bool DeleteUserByEmail(string email);
    }
}
