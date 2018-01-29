using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.workplace.Areas.HelpDesk.VM
{
    public class IssueLiteVM
    {

        public Guid Id { get; set; }
        public string Subject { get; set; }

        public DateTime CreatedOn  { get; set; }

        public string CurrentStatus { get; set; }
    }
}