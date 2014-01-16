using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.UI.WebUI.Controllers
{
    public class ChatController : Controller
    {
        //
        // GET: /Chat/
        public ActionResult Game(string id)
        {
            return View();
        }
	}
}