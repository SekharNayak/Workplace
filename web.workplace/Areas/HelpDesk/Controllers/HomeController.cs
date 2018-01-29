using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.workplace.Areas.HelpDesk.VM;
using Workplace.services.HelpDesk;

namespace web.workplace.Areas.HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHelpDeskService helpDeskService;

        public HomeController(IHelpDeskService helpDeskService )
        {
            this.helpDeskService = helpDeskService;
        }
        // GET: HelpDesk/Home
        public ActionResult Index()
        {
            IEnumerable<IssueLiteVM> issues =  null;
            var issuesCollection = helpDeskService.PopulateUserWall();
            return View(issues.MapIssues(issuesCollection));
        }
        

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
    }
}