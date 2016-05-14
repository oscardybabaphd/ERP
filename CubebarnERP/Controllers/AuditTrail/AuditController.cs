using AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CubebarnERP.Controllers.AuditTrail
{
    public class AuditController : Controller
    {
        //
        // GET: /Audit/
        public ActionResult GetAuditTrails()
        {
            var audits = new AppContextClass().AuditRecords.OrderByDescending(a => a.ActionDate);
            return View(audits);
        }
	}
}