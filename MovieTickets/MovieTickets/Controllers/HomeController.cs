﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTickets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var a = new Entities.MovieTickesDBEntities();
            var b = a.Cinemas.ToArray();
            return View();
        }

    }
}
