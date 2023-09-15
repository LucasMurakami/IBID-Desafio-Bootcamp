using productTeste.Entities;
using productTeste.Repository;

namespace productTeste.services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> getAllProducts()
        {
            return productRepository.getAllProducts();
        }

        Product IProductService.getProductById(int id)
        {
            return productRepository.getProductById(id);
        }

        Product IProductService.postProduct(Product product)
        {
            return productRepository.postProduct(product);
        }

        void IProductService.UpdateProduct(Product product, int id)
        {
            productRepository.UpdateProduct(product, id);
        }

        void IProductService.DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
        }

    }
}