using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workplace.models.IssueTracking;

namespace Workplace.services.HelpDesk
{
    public interface IHelpDeskService
    {
        IEnumerable<Issue> PopulateUserWall();

        bool CreateIssue(Issue issue);
    }
}
