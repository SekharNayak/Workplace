using System;

namespace Workplace.services.Core
{
    public class CoreService : ICoreService
    {

        private readonly Lazy<ISecurityService> securityService;
        private readonly Lazy<IAppService> appService;

        public CoreService(Lazy<ISecurityService> securityService ,
            Lazy<IAppService> appService)
        {
            this.securityService = securityService;
            this.appService = appService;
        }

        public ISecurityService SecurityService => securityService.Value;

        public IAppService AppService => appService.Value;
    }
}
