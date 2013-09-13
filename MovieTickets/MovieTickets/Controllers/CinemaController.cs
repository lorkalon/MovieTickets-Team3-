using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieTickets.Dependency;

namespace MovieTickets.Controllers
{
    [AllowAnonymous]
    public class CinemaController : Controller
    {
        /// <summary>
        /// Public action
        /// </summary>
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfCinemas()
        {
            return View();
        }

        public ActionResult CinemaDetails()
        {
            return View();
        }

        public ActionResult CinemaHalls()
        {
            return View();
        }

        public ActionResult HallDetails()
        {
            return View();
        }


        /// <summary>
        /// User actions
        /// </summary>
        
        [Authorize]
        public ActionResult RateCinema()
        {
            return View();
        }

        [Authorize]
        public ActionResult ReviewCinema()
        {
            return View();
        }

        [Authorize]
        public ActionResult RemoveReview()
        {
            return View();
        }

        /// <summary>
        /// Administrator actions
        /// </summary>

        [Authorize(Roles = "Administrator")]
        public ActionResult AddCinema()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult RemoveCinema()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult EditCinema()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult AddHall()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult RemoveHall()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult EditHall()
        {
            return View();
        }
    }
}
