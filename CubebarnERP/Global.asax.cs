using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IdentityModels;
using System.Data.Entity;
using CubebarnERP.Models;

namespace CubebarnERP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var updateSchemaApp = new DbMigrator(new IdentityModels.Migrations.Configuration());
            updateSchemaApp.Update();

            var updateSchema = new DbMigrator(new AppContext.Migrations.Configuration());
            updateSchema.Update();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
