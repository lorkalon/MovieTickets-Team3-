using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using MovieTickets.Entities;
using MovieTickets.IBLL;
using Ninject;

namespace MovieTickets
{
    public class CustomMembershipProvider : MembershipProvider
    {
        public IAccountService _accountService;

        public CustomMembershipProvider()
        {
            // ????????????????????????????????????????????????????????????????
            var resolver = new Dependency.DependencyResolver();
            _accountService = resolver.GetKernel.Get<IAccountService>();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer,
                                                  bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            status = MembershipCreateStatus.Success;
            return null;
        }

        public MembershipUser CreateUser(string login, string email, string password)
        {
            MembershipUser membershipUser = GetUser(email, false);

            if (membershipUser == null)
            {
                var user = new User
                    {
                        Login = login,
                        Email = email,
                        RegisterDate = DateTime.Now,
                        Blocked = true
                    };

                  if (_accountService.CreateNewUser(user, new Authentication
                      {
                          Password = Crypto.HashPassword(password),
                          User = user
                      }, new ConfirmRegistrationKeys()
                          {
                              User = user,
                              Key = Guid.NewGuid().ToString()
                          }))
                  {
                      return GetUser(email, false);
                  }
            }

            return null;
        }


        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion,
                                                             string newPasswordAnswer)
        {
            return true;
        }

        public override string GetPassword(string username, string answer)
        {
            return "";
        }

        public override bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            Authentication userData = _accountService.GetUserPrivateData(email);

            if (userData != null)
            {
                if (Crypto.VerifyHashedPassword(userData.Password, oldPassword))
                {
                    userData.Password = Crypto.HashPassword(newPassword);
                    
                    if (_accountService.UpdateUserPrivateData(userData))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ResetPassword(string username, string answer)
        {
            return "";
        }

        public override void UpdateUser(MembershipUser user)
        {
        }

        public override bool ValidateUser(string email, string password)
        {
            Authentication userData = _accountService.GetUserPrivateData(email);

            if (userData != null)
            {
                return Crypto.VerifyHashedPassword(userData.Password, password);
            }

            return false;
        }

        public override bool UnlockUser(string userName)
        {
            return true;
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            return null;
        }

        public override MembershipUser GetUser(string email, bool userIsOnline)
        {
            try
            {
                var user = _accountService.GetUserProfile(email);
               
                if (user != null)
                {
                    return new MembershipUser("CustomMembershipProvider", null, null, user.Email, null, null,
                                              false, false, user.RegisterDate, DateTime.MinValue, DateTime.MinValue,
                                              DateTime.MinValue, DateTime.MinValue);
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public override string GetUserNameByEmail(string email)
        {
            User user = _accountService.GetUserProfile(email);

            if (user != null)
            {
                return user.Login;
            }

            return "";
        }

        public override bool DeleteUser(string email, bool deleteAllRelatedData)
        {
            return _accountService.DeleteUserByEmail(email);
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            return new MembershipUserCollection();
        }

        public override int GetNumberOfUsersOnline()
        {
            return 0;
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            return new MembershipUserCollection();
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            return new MembershipUserCollection();
        }

        public override bool EnablePasswordRetrieval
        {
            get { return true; }
        }

        public override bool EnablePasswordReset
        {
            get { return true; }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { return false; }
        }

        public override string ApplicationName { get; set; }

        public override int MaxInvalidPasswordAttempts
        {
            get { return 20; }
        }

        public override int PasswordAttemptWindow
        {
            get { return 0; }
        }

        public override bool RequiresUniqueEmail
        {
            get { return true; }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { return new MembershipPasswordFormat();}
        }

        public override int MinRequiredPasswordLength
        {
            get { return 5; }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { return 0; }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { return ""; }
        }
    }
}