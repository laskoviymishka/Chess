using Chess.UI.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MongoDB.AspNet.Identity;

namespace Chess.UI.WebUI.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; private set; }

        public PlayerController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>("MongoConnection", "Chess"));
        }
        //
        // GET: /Player/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Me()
        {
            return View();
        }
    }
}