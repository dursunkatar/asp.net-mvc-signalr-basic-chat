using System.Web.Mvc;

namespace SignalRBasicChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Chat()
        {
            return View();
        }
    }
}