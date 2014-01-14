using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.UI.WebUI.Controllers
{
    public class RatingController : Controller
    {
        //
        // GET: /Rating/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyRating()
        {
            throw new NotImplementedException();
        }
    }
}