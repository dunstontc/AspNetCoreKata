using System.Collections.Generic;

namespace AspNetCoreKata.ProductRepository
{
    public interface IProductRepo
    {
        Product GetProductWithId(int id);

        IEnumerable<Product> GetAllProducts();
    }
}
