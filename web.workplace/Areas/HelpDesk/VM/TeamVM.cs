using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.workplace.Areas.HelpDesk.VM
{
    public class TeamVM
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<UserVM> Users { get; set; }
    }
}