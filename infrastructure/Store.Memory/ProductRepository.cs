using System;
using System.Linq;

namespace Store.Memory
{
    public class ProductRepository : IProductRepository
    {

        private readonly Product[] products = new[]
        {
            new Product(1, "001"),
            new Product(2, "002"),
            new Product(3, "003"),
        };



        public Product[] GetAllBySKU(string sku)
        {
            return products.Where(product =>  product.SKU.Contains(sku))
                .ToArray();
        }
        
    }
}
