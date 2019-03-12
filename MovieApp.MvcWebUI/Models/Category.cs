using System.Collections.Generic;

namespace MovieApp.MvcWebUI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
    }
}
