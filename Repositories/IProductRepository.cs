using productTeste.Entities;

namespace productTeste.Repository
{
    public interface IProductRepository
    {
        List<Product> getAllProducts();
        Product getProductById(int id);
        Product postProduct(Product product);
        void UpdateProduct(Product product, int id);
        void DeleteProduct(int id);
    }
}