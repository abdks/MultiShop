using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents.ProductListComponents
{
    public class _ProductListSizeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return  View(); } 
    }
}
