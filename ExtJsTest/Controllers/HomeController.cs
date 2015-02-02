using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtJsTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public string Main() {
            return "hello,Main!";
        }

        public string Main2() {
            return "hello,this is another Main!";
        }
    }
}
