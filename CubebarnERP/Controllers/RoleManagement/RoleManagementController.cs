using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CubebarnERP.Controllers.RoleManagement
{
    public class RoleManagementController : Controller
    {
        public RoleManagementController()
        {

        }
        // GET: RoleMangement
        [Authorize]
        public ActionResult AddRole()
        {
            return View();
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