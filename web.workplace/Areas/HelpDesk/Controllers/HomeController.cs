using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.workplace.Areas.HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        // GET: HelpDesk/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}