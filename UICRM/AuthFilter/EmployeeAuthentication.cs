﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UICRM.AuthFilter
{
    public class EmployeeAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["admin"] != null)
                return true;
            httpContext.Response.Redirect("/Account/Login");
            return false;
        }
    }
}