using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTickets.Controllers
{
    public class SessionController : Controller
    {
        /// <summary>
        /// Public actions
        /// </summary>

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfSessions()
        {

            return View();
        }

        public ActionResult SessionDetails()
        {
            return View();
        }

        public ActionResult SearchSession()
        {
            return View();
        }
        [Authorize]
        public ActionResult BookTicket()
        {
            return View();
        }
        [Authorize]
        public ActionResult BuyTicket()
        {
            return View();
        }
        [Authorize]
        public ActionResult ListOfTickets()
        {
            return View();
        }
        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult AddSession()
        {
            return View();
        }
        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult RemoveSession()
        {
            return View();
        }
        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult EditSession()
        {
            return View();
        }
    }
}
