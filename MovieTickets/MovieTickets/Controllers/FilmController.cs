using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieTickets.IBLL;

namespace MovieTickets.Controllers
{
    [AllowAnonymous]
    public class FilmController : Controller
    {
        /// 
        /// Public actions
        /// 
        private IFilmManager _filmManager;                 // That's how create an object by interface
        public FilmController(IFilmManager filmManager)
        {
            _filmManager = filmManager;
        }

        private int _pageSize = 10;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfFilms(int page)
        {
            return View();
        }

        public ActionResult FilmDetails(int filmId)
        {
            return View();
        }

        public ActionResult ShowReviews(int filmId)
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

        [Authorize]
        public ActionResult RateFilm(int filmId, int rating)
        {
            return View();
        }

        [Authorize]
        public ActionResult ReviewFilm(int filmId, string reviewContent)
        {
            return View();
        }

        [Authorize]
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
