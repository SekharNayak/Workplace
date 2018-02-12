using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.workplace.Areas.HelpDesk.VM
{
    public class IssueVM
    {
        
            public int Id { get; set; }
            public string Subject { get; set; }

            public string Description { get; set; }

            public int CreatedBy { get; set; }

            public StatusVM Status { get; set; }

            public string CurrentStatus { get; set; }

            public DateTime CreatedOn { get; set; }

            public TeamVM AssignedTeam { get; set; }

            public string TeamAssignedTo { get; set; }

             public UserVM AssignedTo { get; set; }

            public IList<WorkNoteVM> WorkNotes { get; set; }

            public IEnumerable<SelectListItem> StatusOptions { get; set; }

            public IEnumerable<SelectListItem> TeamOptions { get; set; }


    }
}