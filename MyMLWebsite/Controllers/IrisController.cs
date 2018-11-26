using Ml.DataExchange;
using MyMLWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyMLWebsite.Controllers
{
    [Authorize]
    public class IrisController : Controller
    {
        // GET: Iris
        public ActionResult Index()
        {
            return View("");
        }

        public ActionResult Jam()
        {
            IrisApiViewModel iavm = Ml.Core.Iris.GetClassification();
            IrisViewModel irm = new IrisViewModel
            {
                ResultFlower = iavm.ResultFlower
            };
            return View(iavm);
        }
    }
}