using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CNewsController : Controller
    {
        // GET: CNews
        public ActionResult Index()
        {
            return View();
        }
    }
}