using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BehrendLearningSystem.Services;

namespace BehrendLearningSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModuleService _moduleService;

        public HomeController()
        {
            _moduleService = new ModuleService();
        }
        public ActionResult Index()
        {
            //var results = _moduleService.getHomePage();
            //return View(results);
            return View();
        }

        public ActionResult CoursePage(string courseID)
        {
            //would make a call to classes to get a model full of info
            //return here
            //then will be sent to the view
            ViewBag.Message = "Description about the course";

            var results = _moduleService.GetCourse(courseID);

            return View(results);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Logon()
        {
            ViewBag.Message = "Logon Page";
            return View();
        }

        [HttpPost]
        public ActionResult Logon(string username, string password)
        {
            Session["username"] = "default";
            Session["displayname"] = "Brett P.";
            Session["badgecount"] = "0";
            if (username != "" || username != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Logon");
            }
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register Page";
            return View();
        }

        [HttpPost]
        public ActionResult Register(string email, string fn, string ln, string password)
        {
            Session["username"] = "default";
            Session["displayname"] = fn + " " + ln.Substring(0, 1) + ".";
            Session["badgecount"] = "0";
            return View();
        }

        public ActionResult UserPage()
        {
            ViewBag.Message = "User profile page";
            return View();
        }
    }
}