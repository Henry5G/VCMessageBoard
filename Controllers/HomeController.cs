using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using VCMessageBoard.Models;

namespace VCMessageBoard.Controllers
{
    public class HomeController : Controller
    {
        private VCMessageBoardDB db = new VCMessageBoardDB();

        public ActionResult TestDB ()
        {
            foreach (var item in db.Students)
            {
                ViewBag.Message += item.StudentNum;
            }

            return View();
        }
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
    }
}