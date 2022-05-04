using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naman11.Models;


namespace naman11.Controllers
{
    public class miniController : Controller
    {
        Applicationdbcontext dbcontext = new Applicationdbcontext();
        // GET: mini
        public ActionResult Index()
        {
            List<employess> Employess = dbcontext.employess.ToList();
            return View(Employess);
        }
    }
}