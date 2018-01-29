using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.workplace.Areas.HelpDesk.VM;
using Workplace.models.IssueTracking;

namespace web.workplace.App_Start
{
    public static class MapperConfig
    {
        public static void RegisterMaps()
        {
            // all type mapping goes here .
            AutoMapper.Mapper.Initialize(config =>config.CreateMap<IssueLiteVM, Issue>());
        }
    }
}