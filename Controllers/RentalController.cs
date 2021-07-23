using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veenca.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult Nuovo()
        {
            return View("RentalForm");
        }
    }
}