using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;

namespace MovieApp.MvcWebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult List(int? id)
        {
            if (id.HasValue)
            {
                return View(MovieRepository.Movies.Where(x => x.CategoryId == id).ToList());
            }
            else
            {
                return View(MovieRepository.Movies);
            }            
        }
    }
}