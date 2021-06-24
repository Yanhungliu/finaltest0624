using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s10818140.Controllers
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
        
        public ActionResult Week()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Week(int a)
        {
            var b = "";
            if (a == 1) ViewBag.k = "星期一";
            if (a == 2) ViewBag.k = "星期二";
            if (a == 3) ViewBag.k = "星期三";
            if (a == 4) ViewBag.k = "星期四";
            if (a == 5) ViewBag.k = "星期五";
            if (a == 6) ViewBag.k = "星期六";
            if (a == 7) ViewBag.k = "星期日";




            return View();
        }
    }
}