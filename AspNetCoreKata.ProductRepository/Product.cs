using System;

namespace AspNetCoreKata.ProductRepository
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
