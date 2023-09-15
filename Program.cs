using productTeste.Controllers;
using productTeste.Repository;
using productTeste.services;

class Program
{
    static void Main(string[] args)
    {
        var productRepository = new ProductRepository();
        var productService = new ProductService(productRepository);
        var productController = new ProductController(productService);

        void Run()
        {
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. View Product by ID");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        productController.addProduct();
                        break;

                    case "2":
                        productController.viewAllProducts();
                        break;

                    case "3":
                        productController.viewProductById();
                        break;

                    case "4":
                        productController.updateProduct();
                        break;
                    case "5":
                        productController.deleteProduct();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        Run();
    }
}
