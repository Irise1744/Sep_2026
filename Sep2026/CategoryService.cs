using System;
using System.Collections.Generic;
using System.Text;

namespace Sep2026.ConsoleApp
{
    internal class CategoryService
    {
        public static List<CategoryDto> Categories = new List<CategoryDto>();
        public void AddCategory(string code, string categoryName)

        {
            int maxId = Categories.Count == 0 ? 0 : Categories.Max(x => x.Id);
            CategoryDto category = new CategoryDto
            {   
                Id = Categories.Count + 1,
                Code = code,
                CategoryName = categoryName
            };
            Categories.Add(category);
            Console.WriteLine("Category added successfully");
        }
        public void ShowCategories()
        {
            foreach (var item in Categories)
            {
                Console.WriteLine();
            }
            foreach (var category in Categories)
            {
                Console.WriteLine($"Category:{category.Id}, Code: {category.Code}, Name: {category.CategoryName}");
            }
        }
    }
}
