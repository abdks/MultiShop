using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Areas.Admin.AdminLayoutViewComponents
{
    public class _AdminLayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
  
}
