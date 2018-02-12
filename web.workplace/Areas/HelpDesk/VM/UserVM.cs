using System.Collections.Generic;

namespace web.workplace.Areas.HelpDesk.VM
{
    public class UserVM
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public int EmployeeId { get; set; }

        public IList<TeamVM> Teams { get; set; }
    }
}