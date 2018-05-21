using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Mvc;

namespace ServiceStack.Hello.Controllers
{
    public class ArtistController : ServiceStackController
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.MyHeader = "Hello World";
            return View();
        }
    }
}