using System;
using System.Collections.Generic;
using System.Text;

namespace Sep2026.ConsoleApp
{
    internal class SaleService
    {
        public static List<SaleDto> Sales = new List<SaleDto>();
        public void AddSale(string productCode, int quantity)
        {
            int maxId = Sales.Count == 0 ? 0 : Sales.Max(x => x.Id);

            // Looks up product using the Code field from your ProductDto
            ProductDto item = ProductService.Products.Where(x => x.Code == productCode).FirstOrDefault();

            if (item != null)
            {
                SaleDto sale = new SaleDto
                {
                    Id = maxId + 1,
                    ProductId = item.Id,
                    ProductName = item.Name,
                    Quantity = quantity,
                    TotalPrice = item.Price * quantity
                };

                Sales.Add(sale);
                Console.WriteLine("Sale registered successfully!");
            }
            else
            {
                Console.WriteLine("Product code not found!");
            }
        }
        public void ShowSales()
        {
            Console.WriteLine("\n--- Sales History Report ---");
            foreach (var item in Sales)
            {
                Console.WriteLine($"Sale ID: {item.Id} | Product: {item.ProductName} | Qty: {item.Quantity} | Total: ${item.TotalPrice}");
            }
        }
    }
}
