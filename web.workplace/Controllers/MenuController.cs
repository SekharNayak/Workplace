using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.workplace.VM;
using Workplace.services.Core;

namespace web.workplace.Controllers
{
    public class MenuController : Controller
    {
        private readonly ICoreService coreService;


        public MenuController(ICoreService coreService)
        {
            this.coreService = coreService;
        }
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Header() {
                   
     
            return PartialView(GetMenuByAppName());
        }

        private MenuVM GetMenuByAppName() {
            //get the area name to dynamically populate the menu .
            var areaName = HttpContext.Request.RequestContext.RouteData.DataTokens["area"];
            if (areaName != null && !string.IsNullOrEmpty(areaName.ToString()))
            {
                var listItems = coreService.AppService.GetMenuByAppName(areaName.ToString());
                return new MenuVM()
                {
                    DisplayName = "",
                    IsAuthenticated = true,
                    MenuItems = new List<Item>() {

                        new Item() {
                            ControllerName = "Issue",
                            ActionName = "Create",
                            AreaName = "HelpDesk",
                            ItemText = "CreateRequest"
                        },
                         new Item() {
                            ControllerName = "Home",
                            ActionName = "Index",
                            AreaName = "HelpDesk",
                            ItemText = "Dashboard"
                        },
                        new Item() {
                            ControllerName = "Issue",
                            ActionName = "Assigned",
                            AreaName = "HelpDesk",
                            ItemText = "Inbox"
                        }
                    }
                };
            }
            else
            {
                return new MenuVM() {

                    DisplayName = "",
                    IsAuthenticated = true ,
                    MenuItems = new List<Item>() {

                    }
                };
            }
           
        } 
    }
}