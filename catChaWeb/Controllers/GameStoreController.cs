using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catChaWeb.Controllers
{
    public class GameStoreController : Controller
    {
        // GET: GameStore
        public ActionResult Index()
        {
            return View();
        }
    }
}