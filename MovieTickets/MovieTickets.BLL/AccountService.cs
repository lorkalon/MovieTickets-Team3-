using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;
using MovieTickets.IBLL;
using MovieTickets.IDAL;

namespace MovieTickets.BLL
{
    public class AccountService: IAccountService
    {
        private IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool CreateNewUser(User user, Authentication authentication, ConfirmRegistrationKeys registrationKeys)
        {
            try
            {
                IUserRepository userRepository = _unitOfWork.GetIUserRepository();
                userRepository.Insert(user);
                _unitOfWork.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User GetUserProfile(string email)
        {
            IUserRepository userRepository = _unitOfWork.GetIUserRepository();
            return userRepository.GetByEmail(email);  
        }

        public Authentication GetUserPrivateData(string email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserProfile(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserPrivateData(Authentication data)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
