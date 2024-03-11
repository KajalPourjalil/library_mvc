namespace library_mvc.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Kimetso no yaiba", Author = "Tsukasa Iori" },
            new Category { CategoryId = 2, Name = "Shahname", Author = "Ferdosi"},
            new Category { CategoryId = 3, Name = "Dracula", Author = "Bram Stoker"}
        };

        public static void AddCategoory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        
    }
}