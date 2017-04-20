using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DFEitechPublic.Controllers
{
    public class ElectronicsController : Controller
    {
        // GET: Electronics
        public ActionResult index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult location()
        {
            return View();
        }

        [HttpGet]
        public ActionResult competency()
        {
            return View();
        }

        [HttpGet]
        public ActionResult management()
        {
            return View();
        }

        [HttpGet]
        public ActionResult software()
        {
            return View();
        }

        [HttpGet]
        public ActionResult staff()
        {
            return View();
        }

        [HttpGet]
        public ActionResult systems()
        {
            return View();
        }
    }
}