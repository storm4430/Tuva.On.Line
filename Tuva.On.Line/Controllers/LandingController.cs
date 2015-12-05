using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuva.On.Line.Controllers
{
    [Authorize]
    public class LandingController : Controller
    {
        /// <summary>
        /// Верхнее меню
        /// </summary>
        /// <returns></returns>
        public ActionResult HorizontalTop()
        {
            return PartialView();
        }
        
        /// <summary>
        /// Основное меню
        /// </summary>
        /// <returns></returns>
        public ActionResult NavMenu()
        {
            return PartialView();
        }
    }
}