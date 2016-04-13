using portfolio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace portfolio2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Resume() {
            return View();
        }

        public ActionResult Accomplishments() {
            return View();
        }

        public ActionResult PongGame() {
            return View();
        }

        public ActionResult Chart()
        {
            return View();
        }

        public ActionResult Radio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult formsubmit(String name, String email, String messge) {

            return View();
        }
    }
}