using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quartzdemo.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 5)]//control缓存，粒度较大
        [OutputCache(CacheProfile = "Testconfigcache")]//采用配置文件批量缓存设置方法
        public ActionResult Index()
        {
            ViewBag.Currentime = DateTime.Now;
            return View();
        }
    }
}