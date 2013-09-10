using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTickets.Controllers
{
    [AllowAnonymous]
    public class FilmController : Controller
    {
        /// 
        /// Public actions
        /// 

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfFilms()
        {
            return View();
        }

        public ActionResult FilmDetails()
        {
            return View();
        }

        public ActionResult ShowReviews()
        {
            return View();
        }

        public ActionResult SearchFilm()
        {
            return View();
        }

        ///
        ///Actions for authorized users
        ///
        /// 
        [Authorize(Roles = "User, Administrator, Moderator")]
        public ActionResult RateFilm()
        {
            return View();
        }

        [Authorize(Roles = "User, Administrator, Moderator")]
        public ActionResult ReviewFilm()
        {
            return View();
        }

        [Authorize(Roles = "User, Administrator, Moderator")]
        public ActionResult RemoveReview()
        {
            return View();
        }

        ///
        /// Actions for moderators
        /// 
        
        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult AddFilm()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult RemoveFilm()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult EditFilm()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult BanReview()
        {
            return View();
        }


    }
}
