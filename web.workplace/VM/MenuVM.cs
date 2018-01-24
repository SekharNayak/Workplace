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

        public string ItemPath { get; set; }
    }
}