using AppContext;
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
        public ActionResult AddRole(FormCollection obj)
        {
            return View();
        }

    }
}