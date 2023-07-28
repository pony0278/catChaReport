using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catChaWeb.Controllers
{
    public class SummonController : Controller
    {
        // GET: Summon
        public ActionResult 所有物品()
        {
            catchaEntities db= new catchaEntities();
            var datas = from p in db.Game_Product_Total
                        where p.Lottery_Probability > 0
                        select p;
            return View(datas);
        }
    }
}