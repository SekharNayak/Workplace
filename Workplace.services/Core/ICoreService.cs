using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.services.Core
{
    public interface ICoreService
    {
         ISecurityService SecurityService { get;  }

        IAppService AppService { get; }

    }
}
