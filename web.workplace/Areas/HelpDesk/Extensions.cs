using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.workplace.Areas.HelpDesk.VM;
using Workplace.models.IssueTracking;

namespace web.workplace.Areas.HelpDesk
{
    public static class HelpDeskExtensions
    {
        public static IEnumerable<IssueLiteVM> MapIssues(this IEnumerable<IssueLiteVM> issues, IEnumerable<Issue> issuesCollection) {

            if (issuesCollection != null && issuesCollection.ToList().Count > 0) {

               return AutoMapper.Mapper.Map<IEnumerable<IssueLiteVM>>(issuesCollection);
            }
            return null;
        }
    }
}