using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{

    //[Authorize]  // can also put on the Controller level - apply all the actions inside the controller
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //public ActionResult Index()
        //{
        //    return View();
        //}


        //[Authorize]  // user has to be logged in, or will be redirect to the login page
        //[Authorize(Roles = "Admin")] // loggin as Admin role

        //[HttpGet]  // can be only invoked by doing http post message
        
        [Log]
        public ActionResult Search(string name = "french") // adding a parameter
        {
            // preventing malicious code
            var message = Server.HtmlEncode(name);

            throw new Exception("Something terrible has happened");

            return Content(message);
            //return RedirectPermanent("https://www.microsoft.com/");
            //return RedirectToAction("Index", "Home", new {name = name});  // temporary redirect
            //return RedirectToRoute("Default", new {controller = "Home", action = "About"});
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new {Message = message, Name = "Scott"}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost] // can be only invoked by doing http get message
        public ActionResult Search()
        {
            return Content("Search!");
        }
    }
}