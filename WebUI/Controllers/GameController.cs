using Chess.UI.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.UI.WebUI.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyGames()
        {
            return View();
        }

        public ActionResult CreateGame(string Player1Id, string Player2Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGame(CreateGameViewModel model)
        {
            return View();
        }

        public ActionResult Game(string id)
        {
            return View();
        }
    }
}