using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.workplace.Areas.HelpDesk.Controllers
{
    public class IssueController : Controller
    {
        // GET: HelpDesk/Issue
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Detail(Guid? Id)
        {

            return View();
        }
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Assigned()
        {

            return View();
        }
    }
}