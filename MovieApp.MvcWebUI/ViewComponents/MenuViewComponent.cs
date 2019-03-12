using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;

namespace MovieApp.MvcWebUI.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}
