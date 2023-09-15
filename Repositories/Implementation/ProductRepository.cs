using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productTeste.Entities;

namespace productTeste.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> productList = new List<Product>();
        private int idCounter = 1;

        List<Product> IProductRepository.getAllProducts()
        {
            return productList;
        }

        Product IProductRepository.getProductById(int id)
        {
            var productVerify = productList.FirstOrDefault(p => p.Id == id);
            if (productVerify != null)
                return productVerify;
            else
                return new Product();
        }

        Product IProductRepository.postProduct(Product product)
        {
            product.Id = idCounter++;
            productList.Add(product);
            return product;
        }

        void IProductRepository.UpdateProduct(Product product, int id)
        {
            var productVerify = productList.FirstOrDefault(p => p.Id == id);
            if (productVerify != null)
            {
                productVerify.Name = product.Name;
                productVerify.Description = product.Description;
            }

        }

        void IProductRepository.DeleteProduct(int id)
        {
            var productVerify = productList.FirstOrDefault(p => p.Id == id);
            if (productVerify != null)
                productList.Remove(productVerify);
        }
    }
}