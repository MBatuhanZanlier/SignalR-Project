using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents._AdminLayout
{
    public class _AdminLayoutFooterPartialComponent:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
