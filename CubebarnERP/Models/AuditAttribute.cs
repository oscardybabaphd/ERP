using IdentityModels.Models.Entities.AuditModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace CubebarnERP.Models
{
    public class AuditAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Stores the Request in an Accessible object
            var request = filterContext.HttpContext.Request;
           // var sessionIdentifier = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(request.Cookies[FormsAuthentication.FormsCookieName].Value)).Select(s => s.ToString("x2")));
            
            //Generate an audit
            AuditModel audit = new AuditModel()
            {
                //SessionID = sessionIdentifier,
                IPAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? request.UserHostAddress,
                URLAccessed = request.RawUrl,
                ActionDate = DateTime.UtcNow,
                UserName = (request.IsAuthenticated) ? filterContext.HttpContext.User.Identity.Name : "Anonymous",
                Data = SerializeRequest(request)
            };

            //Stores the Audit in the Database
            using (AppContext.AppContextClass context = new AppContext.AppContextClass())
            {
                context.AuditRecords.Add(audit);
                context.SaveChanges(); 
            }

            base.OnActionExecuting(filterContext);
        }

        //This will serialize the Request object
        private string SerializeRequest(HttpRequestBase request)
        {
            //We can't simply just Encode the entire request string due to circular references as well
            //as objects that cannot "simply" be serialized such as Streams, References etc.
            //return Json.Encode(request);
            return Json.Encode(new { request.Files, request.Form });
            
        }
    }
}