using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.workplace.VM;

namespace web.workplace.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Header(string appName = "root") {

            var menu = new MenuVM() { IsAuthenticated = false , DisplayName = "" , MenuItems = new List<Item>() };
            return PartialView(menu);
        }
    }
}