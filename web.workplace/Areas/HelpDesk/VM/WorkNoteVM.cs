namespace web.workplace.Areas.HelpDesk.VM
{
    using System;
    using System.Collections.Generic;

    public class WorkNoteVM
    {
        public Guid WorkNoteId { get; set; }

        public string Note { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public IList<AttachedItemVM> Attachments { get; set; }
    }
}