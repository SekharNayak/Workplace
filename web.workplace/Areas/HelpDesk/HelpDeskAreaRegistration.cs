using System.Web.Mvc;

namespace web.workplace.Areas.HelpDesk
{
    public class HelpDeskAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HelpDesk";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            // route name is very important as it gives us the appname 
            // so that dynamically links can be generated .
            // please chage the db entry whenever the route changes.
            context.MapRoute(
                "HelpDesk_default",
                "HelpDesk/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                null,
                new []{ "web.workplace.Areas.HelpDesk.Controllers" }
            );
        }
    }
}