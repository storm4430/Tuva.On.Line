using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Tuva.On.Line.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
