using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.workplace.Areas.HelpDesk.VM;
using Workplace.services.HelpDesk;

namespace web.workplace.Areas.HelpDesk.Controllers
{
    public class IssueController : Controller
    {

        private readonly IHelpDeskService helpDeskService;
        private IEnumerable<SelectListItem> statusOptions = null;
        private IEnumerable<SelectListItem> teamOptions = null;

        private string CurrentStatus;
        private string CurrentTeam;

        public IssueController(IHelpDeskService helpDeskService)
        {
            this.helpDeskService = helpDeskService;
            statusOptions = GetStatusOptions();
            teamOptions = GetStatusOptions();
        }
        // GET: HelpDesk/Issue
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Detail(Guid? Id)
        {

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var issueVM = new IssueVM() { };
            issueVM.StatusOptions = statusOptions ?? GetStatusOptions();
            issueVM.TeamOptions = teamOptions ?? GetStatusOptions();
            return View(issueVM);
        }
        [HttpPost]
        public ActionResult Create(IssueVM issue)
        {

            if (ModelState.IsValid)
            {

            }
            var issueVM = new IssueVM() { };
            issueVM.StatusOptions = statusOptions ?? GetStatusOptions();
            issueVM.TeamOptions = teamOptions ?? GetStatusOptions();
            return View(issueVM);
        }
        public ActionResult Assigned()
        {

            return View();
        }

        private List<SelectListItem> GetStatusOptions() {
            var statusCollection = helpDeskService.GetStatus();
            var options = (from status in statusCollection
                          select new SelectListItem() {
                              Text = status.StatusDescription,
                              Value = status.StatusId.ToString()
                          }).ToList();

            return options;
        }
    }
}