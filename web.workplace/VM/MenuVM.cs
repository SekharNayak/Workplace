using System;
using System.Collections.Generic;

namespace web.workplace.VM
{
    public class MenuVM
    {
        public bool IsAuthenticated { get; set; }
        public string  DisplayName { get; set; }

        public List<Item> MenuItems { get; set; }
    }

    public class Item
    {
        public string ItemText { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string AreaName { get; set; }


    }
}