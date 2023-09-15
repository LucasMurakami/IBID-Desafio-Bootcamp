using productTeste.Entities;
using productTeste.services;

namespace productTeste.Controllers
{

    public class ProductController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public void viewAllProducts()
        {
            var products = productService.getAllProducts();
            if (products.Count > 0)
                foreach (var existingProduct in products)
                    Console.WriteLine($"Product ID: {existingProduct.Id} | Name: {existingProduct.Name} | Description: {existingProduct.Description}");
            else
                Console.WriteLine("No products found. ");
        }

        public void viewProductById()
        {
            Console.Write("Enter Product ID: ");
            if (int.TryParse(Console.ReadLine(), out int productId))
            {
                var existingProduct = productService.getProductById(productId);
                if (existingProduct.Id > 0)
                    Console.WriteLine($"Product ID: {existingProduct.Id} | Name: {existingProduct.Name} | Description: {existingProduct.Description}");
                else
                    Console.WriteLine("Product not found with id: " + productId);
            }
            else
                Console.WriteLine("Invalid input.");
        }

        public void addProduct()
        {
            Console.Write("Enter Product Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Product Description: ");
            var description = Console.ReadLine();
            Product p = productService.postProduct(new Product { Name = name, Description = description });
            Console.WriteLine("Product created successfully.");
            Console.WriteLine($"Product ID: {p.Id} | Name: {p.Name} | Description: {p.Description}");
        }

        public void updateProduct()
        {
            Console.Write("Enter Product ID to Update: ");
            if (int.TryParse(Console.ReadLine(), out int updateId))
            {
                var existingProduct = productService.getProductById(updateId);
                if (existingProduct.Id > 0)
                {
                    Console.Write("Enter New Product Title: ");
                    existingProduct.Name = Console.ReadLine();
                    Console.Write("Enter New Product Description: ");
                    existingProduct.Description = Console.ReadLine();
                    productService.UpdateProduct(existingProduct, updateId);
                }
                else
                    Console.WriteLine("Product not found with id: " + updateId);
            }
            else
                Console.WriteLine("Invalid input.");
        }

        public void deleteProduct()
        {
            Console.Write("Enter Product ID to Delete: ");
            if (int.TryParse(Console.ReadLine(), out int deleteId))
            {
                var existingProduct = productService.getProductById(deleteId);
                if (existingProduct.Id > 0)
                {
                    productService.DeleteProduct(deleteId);
                    Console.WriteLine("Product deleted successfully!");
                }
                else
                    Console.WriteLine("Product not found with id: " + deleteId);
            }
            else
                Console.WriteLine("Invalid input.");
        }
    }
}