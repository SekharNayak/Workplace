using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workplace.models.IssueTracking;

namespace Workplace.services.HelpDesk
{
    public class HelpDeskService : IHelpDeskService
    {
        public bool CreateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Issue> PopulateUserWall()
        {
          return  new List<Issue>() {

                    new Issue() {

                            AssignmentGroupId = 1,
                            CreatedBy = 1,
                            CreatedOn = DateTime.Now,
                            CurrentHandler = 5,
                            CurrentStatus = "Created",
                            Subject="Example Issue",
                            StatusId = 1,
                            Id = Guid.NewGuid(),
                            Description ="Software Installation"

                    },
                    new Issue() {

                            AssignmentGroupId = 2,
                            CreatedBy = 2,
                            CreatedOn = DateTime.Now,
                            CurrentHandler = 6,
                            CurrentStatus = "Created",
                            Subject="Example Issue",
                            StatusId = 2,
                            Id = Guid.NewGuid(),
                            Description ="Software Installation"

                    }
            };

            
        }
    }
}
