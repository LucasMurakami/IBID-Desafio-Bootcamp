using productTeste.Entities;

namespace productTeste.services
{
    public interface IProductService
    {
        List<Product> getAllProducts();
        Product getProductById(int id);
        Product postProduct(Product product);
        void UpdateProduct(Product product, int id);
        void DeleteProduct(int id);
    }
}