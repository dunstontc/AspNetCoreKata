using System.Data;
using System.Linq;
using Dapper;

namespace AspNetCoreKata.ProductRepository
{
    public class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;
        
        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public Product GetProductWithId(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Product>("SELECT * FROM product WHERE productid = @id", new { id }).FirstOrDefault();
            }
        }
    }
}
