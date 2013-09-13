using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MovieTickets.Models.AccountModels;

namespace MovieTickets.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Registration/
        [AllowAnonymous]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var provider = (CustomMembershipProvider) Membership.Provider;
                MembershipUser membershipUser = provider.CreateUser(model.Login,model.Email, model.Password);

                if (membershipUser != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Index","Home");
                }

                ModelState.AddModelError("EmailError", "Email is already exist.");
            }

            ModelState.AddModelError("RegisterError", "Input data is incorrect.");
            
            return View(model);
        }
/*
        [AllowAnonymous]
        public ActionResult LoginPartial()
        {
            if (User.Identity.IsAuthenticated)
            {
                return PartialView("_LogOnPartial");
            }

            return PartialView("_LogOffPartial");
        }


        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Email, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Categories", "Food");
                }
            }

            ModelState.AddModelError("Login error", "Email or password is incorrect");
            return View(returnUrl, model);
        }

        [Authorize]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Categories", "Food");
        }

        [Authorize]
        public ActionResult EditUserProfile()
        {
            var accountService = new AccountService();
            UserProfileViewModel model = (accountService.GetUserByEmail(User.Identity.Name)).ToUserProfileViewModel();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditUserProfile(UserProfileViewModel model)
        {
            IAccountService accountService = new AccountService();
            UserProfileModel oldProfile = accountService.GetUserByEmail(User.Identity.Name);

            if (accountService.UpdateUserProfile(model.ToUserProfileModel(oldProfile), false))
            {
                return RedirectToAction("Categories", "Food");
            }

            ModelState.AddModelError("UpdateError", "Update failed!");
            return View(model);
        }

        [Authorize]
        public ActionResult EditUserPassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditUserPassword(UserPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                IAccountService accountService = new AccountService();
                UserProfileModel oldProfile = accountService.GetUserByEmail(User.Identity.Name);
                string modelPassword = accountService.HashPassword(model.Password);

                if (oldProfile.Password == modelPassword)
                {
                    if (accountService.UpdateUserProfile(model.ToUserProfileModel(oldProfile), true))
                    {
                        return RedirectToAction("Categories", "Food");
                    }

                    ModelState.AddModelError("UpdateError", "Update failed!");
                    return View(model);
                }

                ModelState.AddModelError("PasswordError", "Current password is incorrect");
            }

            return View(model);
        }
        */
    }
}
