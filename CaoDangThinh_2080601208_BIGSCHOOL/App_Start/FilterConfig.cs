﻿using System.Web;
using System.Web.Mvc;

namespace CaoDangThinh_2080601208_BIGSCHOOL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
