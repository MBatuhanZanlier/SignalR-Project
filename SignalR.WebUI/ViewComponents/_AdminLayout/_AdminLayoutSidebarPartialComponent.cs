using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents._AdminLayout
{
    public class _AdminLayoutSidebarPartialComponent:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
