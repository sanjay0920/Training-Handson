﻿using System.Web;
using System.Web.Mvc;

namespace EMS_FULL_STACK_PROJECT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
