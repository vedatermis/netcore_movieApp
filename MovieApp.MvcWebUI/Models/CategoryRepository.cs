using System.Collections.Generic;
using System.Linq;

namespace MovieApp.MvcWebUI.Models
{
    public class CategoryRepository
    {
        private static List<Category> categories = null;
        static CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category {Id = 1, Name = "Category 1"},
                new Category {Id = 2, Name = "Category 2"},
                new Category {Id = 3, Name = "Category 3"}
            };
        }


        public static List<Category> Categories => categories;

        public static void AddMovie(Category movie)
        {
            categories.Add(movie);
        }

        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
