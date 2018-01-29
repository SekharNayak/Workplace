using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Workplace.services.Account;
using Workplace.services.Core;
using Workplace.services.HelpDesk;

namespace web.workplace
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IHelpDeskService, HelpDeskService>();

            container.RegisterType<IAppService, AppService>();
            container.RegisterType<ISecurityService, SecurityServices>();
            container.RegisterType<ICoreService, CoreService>();
            

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}