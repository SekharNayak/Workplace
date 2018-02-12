using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.workplace.Areas.HelpDesk.VM;
using Workplace.models.IssueTracking;

namespace web.workplace.Areas.HelpDesk
{
    /// <summary>
    /// Extension methods for HelpDesk section.
    /// </summary>
    public static class HelpDeskExtensions
    {
        public static IEnumerable<IssueLiteVM> MapIssues(this IEnumerable<IssueLiteVM> issues, IEnumerable<Issue> issuesCollection) {

            if (issuesCollection != null && issuesCollection.ToList().Count > 0) {

                //please refer mapconfig file for individual mapping details.
               return AutoMapper.Mapper.Map<IEnumerable<IssueLiteVM>>(issuesCollection);
            }
            return null;
        }
    }
}