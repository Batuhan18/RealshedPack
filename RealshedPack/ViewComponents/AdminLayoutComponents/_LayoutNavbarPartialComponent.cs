using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.AdminLayoutComponents
{
    public class _LayoutNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
