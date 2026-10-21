using System;

namespace Sep2026.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            SaleService saleService = new SaleService();
            CategoryService categoryService = new CategoryService();
            bool exit = false;

        Start:

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("    SUPERMARKET MANAGEMENT");
                Console.WriteLine("================================");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Make a Sale");
                Console.WriteLine("4. View Sales");
                Console.WriteLine("5. View Categories");
                Console.WriteLine("6. Add Category");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        productService.ShowProducts();
                        break;

                    case "2":
                        Console.WriteLine("\n--- Add New Product ---");
                        Console.Write("Enter Code: ");
                        string code = Console.ReadLine();

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        decimal.TryParse(Console.ReadLine(), out decimal price);

                        productService.AddProduct(code, name, price);
                        break;

                    case "3":
                        Console.WriteLine("\n--- Make a Sale ---");
                        productService.ShowProducts();

                        Console.Write("\nEnter Product Code: ");
                        string productCode = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        int.TryParse(Console.ReadLine(), out int quantity);

                        saleService.AddSale(productCode, quantity);
                        break;

                    case "4":
                        saleService.ShowSales();
                        break;

                    case "5":
                        categoryService.ShowCategories();
                        break;

                    case "6":
                        Console.WriteLine("\n--- Add New Category ---");
                        Console.Write("Enter Category Code: ");
                        string catCode = Console.ReadLine();

                        Console.Write("Enter Category Name: ");
                        string catName = Console.ReadLine();

                        categoryService.AddCategory(catCode, catName);
                        break;

                    case "0":
                        goto End;

                    default:
                        Console.WriteLine("Please enter a number between 0 and 5.");
                        break;
                }

                Console.WriteLine("\nPress Enter to return to main menu...");
                Console.ReadLine();
                goto Start;

            End:
                Console.WriteLine("\nExiting app...");
            }
        }
    }
}