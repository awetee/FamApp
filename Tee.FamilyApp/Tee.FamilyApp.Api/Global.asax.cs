﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Tee.FamilyApp.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
