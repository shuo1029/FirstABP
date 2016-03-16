using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstABP.Web.Controllers
{
    public class UserController : FirstABPControllerBase
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}