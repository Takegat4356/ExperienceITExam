using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiceRoll.Controllers
{
    public class DiceController : Controller
    {
        // GET: Dice
        public ActionResult Index()
        {

            var rolls = from x in Enumerable.Range(1, 6)
                        from y in Enumerable.Range(1, 6)
                        select new DiceRoll.Models.DiceRoll
                        { DieOne = x, DieTwo = y };
            return View(rolls);
        }
    }
}