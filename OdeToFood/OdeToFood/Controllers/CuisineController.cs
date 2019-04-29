using System.Web.Mvc;
using System.Web.Services.Description;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Search(string name = "french") // parameter as input - need to be as same as defined in the MapRoute
        {
            var message = Server.HtmlEncode(name); // encoding - prevent malicious code injection (RazorView Engine will do this automatically)
            return Content(message);   // will send string back to the browser
//            return RedirectPermanent("http://microsoft.com"); // returns a 301 status code
//            return RedirectToAction("Index", "Home",new { id = name });
//            return RedirectToRoute("Default", new {Controller = "Home", action = "about"});
//            return File(Server.MapPath("~/Content/site.css"),"text/css"); 
//            return Json(new {Message = message, Name = "Scott"}, JsonRequestBehavior.AllowGet);
        }
    }
}