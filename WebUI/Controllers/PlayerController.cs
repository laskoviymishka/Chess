using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.UI.WebUI.Controllers
{
    public class PlayerController : Controller
    {
        //
        // GET: /Player/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Me()
        {
            throw new NotImplementedException();
        }
    }
}