using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filterdemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, string url)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                return Redirect(url ?? Url.Action("Index", "Admin"));
            }
            else
            {
                ModelState.AddModelError("错误集合","验证错误");
                return View();
            }
        }
    }
    public class Userfilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}