using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.models.IssueTracking
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public int StatusId { get; set; }

        public string CurrentStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public int AssignmentGroupId { get; set; }

        public int CurrentHandler { get; set; }


    }
}
