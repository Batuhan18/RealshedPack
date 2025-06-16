using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.AdminLayoutComponents
{
    public class _LayoutSidebarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
