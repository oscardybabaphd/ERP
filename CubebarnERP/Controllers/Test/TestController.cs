using CubebarnERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CubebarnERP.Controllers.Test
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        [Audit]
        public ActionResult Index()
        {
            return View();
        }
	}
}