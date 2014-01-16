using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.UI.WebUI.Controllers
{
    public class TrainingsController : Controller
    {
        //
        // GET: /Trainings/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyTraining()
        {
            return View();
        }

        public ActionResult CreateAiGame(string playerId)
        {
            return View();
        }

        public ActionResult CreatePazzle(string playerId, string PazzleId)
        {
            return View();
        }
    }
}