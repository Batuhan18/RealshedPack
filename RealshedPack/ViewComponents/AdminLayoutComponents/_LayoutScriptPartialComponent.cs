using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.AdminLayoutComponents
{
    public class _LayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
