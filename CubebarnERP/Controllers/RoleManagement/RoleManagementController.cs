<<<<<<< HEAD
﻿using CubebarnERP.Models;
=======
﻿using AppContext;
>>>>>>> 54b4832e3222206ff5491f5517293b0304273b0a
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CubebarnERP.Controllers.RoleManagement
{
    public class RoleManagementController : Controller
    {
        AppContextClass session = null;
        public RoleManagementController()
        {
            session = new AppContextClass();
        }
        // GET: RoleMangement
        [Authorize]
        public ActionResult AddRole()
        {
            var SiteMapList = session.SiteMapParentNode.Include("SiteMapSubParentNode").ToList();
            //TempData["SiteMap"] = SiteMapList;
            return View(SiteMapList);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        [Audit]
        public ActionResult AddRole(FormCollection obj)
        {
            return View();
        }

    }
}