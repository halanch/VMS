using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["userID"]!=null)
            {
                return RedirectToAction("Home", "Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserID,string Password)
        {
            if (Session["userID"] != null)
            {
                return RedirectToAction("Home", "Index");
            }
            return View();
        }
    }
}