using AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityModels.Models.Entities;


namespace CubebarnERP.Controllers.SiteMap
{
    public class SiteMapController : Controller
    {
        public IEnumerable <SiteMapParentNode> SessionSiteMap
        {
            get
            {
                if(Session["SessionSiteMap"] == null)
                {
                    Session["SessionSiteMap"] = new List<SiteMapParentNode>();
                }
                return Session["SessionSiteMap"] as List<SiteMapParentNode>;
            }
            set
            {
                Session["SessionSiteMap"] = value;
            }
        }
        AppContextClass session = null;
        CubebarnRepository.SiteMapRep.SiteMap SiteMapRepo = null;
        public SiteMapController()
        {
            session = new AppContextClass();
            SiteMapRepo = new CubebarnRepository.SiteMapRep.SiteMap();
        }
        // GET: SiteMap
        public ActionResult SiteMap()
        {
            if(SessionSiteMap.Count() == 0)
            {
                var SiteMapList = session.SiteMapParentNode.Include("SiteMapSubParentNode").ToList();
                if (SiteMapList.Count() > 0)
                {
                    SessionSiteMap = SiteMapList;
                }
            }
            return PartialView("_SiteMapPartial");
        }
    }
}