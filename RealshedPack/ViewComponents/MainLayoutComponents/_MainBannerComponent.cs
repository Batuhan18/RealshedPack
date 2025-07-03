using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.ViewComponents.MainLayoutComponents
{
    public class _MainBannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
