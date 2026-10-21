using Sep2026.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sep2026.ConsoleApp
{
    public class ProductService
    {
        public static List<ProductDto> Products = new List<ProductDto>();

        public void AddProduct(string code, string name, decimal price)
        {
            int maxId = Products.Count == 0 ? 0 : Products.Max(x => x.Id);

            ProductDto product = new ProductDto
            {
                Id = maxId + 1,
                Code = code,
                Name = name,
                Price = price
            };

            Products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void ShowProducts()
        {
            Console.WriteLine("\n--- Supermarket Product List ---");
            foreach (var item in Products)
            {
                Console.WriteLine($"Id: {item.Id} | Code: {item.Code} | Name: {item.Name} | Price: ${item.Price}");
            }
        }
    }
}