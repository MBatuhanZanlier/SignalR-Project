using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
