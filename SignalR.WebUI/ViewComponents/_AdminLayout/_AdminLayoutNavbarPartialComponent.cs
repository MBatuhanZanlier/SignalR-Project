using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents._AdminLayout
{
    public class _AdminLayoutNavbarPartialComponent:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
