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
                new Category() {Id = 1, Name = "Category 1",},
                new Category() {Id = 2, Name = "Category 2",},
                new Category() {Id = 3, Name = "Category 3",},
                new Category() {Id = 4, Name = "Category 4",},
                new Category() {Id = 5, Name = "Category 5",},
                new Category() {Id = 6, Name = "Category 6",},
                new Category() {Id = 7, Name = "Category 7",},
                new Category() {Id = 8, Name = "Category 8",},
                new Category() {Id = 9, Name = "Category 9",},
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
