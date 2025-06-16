using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.AdminLayoutComponents
{
    public class _LayoutFooterPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
