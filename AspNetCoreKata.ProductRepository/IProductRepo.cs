using System.Collections.Generic;

namespace AspNetCoreKata.ProductRepository
{
    public interface IProductRepo
    {
        Product GetProductWithId(int id);

        IEnumerable<Product> GetAllProducts();

        void DeleteProduct(int id);
        
        void UpdateProduct(int id, string name);
    }
}
