namespace AspNetCoreKata.ProductRepository
{
    public interface IProductRepo
    {
        Product GetProductWithId(int id);
    }
}
