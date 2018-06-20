using Desafio.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<int[]> results = new List<int[]>();
            for (int i = 1; i < 4; i++)
                results.Add(MegaSena.GetMegaSena(i));

            return View(results);
        }
    }
}