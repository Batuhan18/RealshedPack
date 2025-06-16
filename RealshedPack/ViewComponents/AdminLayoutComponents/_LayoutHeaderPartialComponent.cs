using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.AdminLayoutComponents
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
