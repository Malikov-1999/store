using System;
using System.Linq;

namespace Store.Memory
{
    public class ProductRepository : IProductRepository
    {

        private readonly Product[] products = new[]
        {
            new Product(1, "ISBN 123-456-789 0", "D. Knuth", "Art of Programming"),
            new Product(2, "ISBN 123-456-789 1", "D. Knuth", "Art of Programming")
            
        };

        public Product[] GetAllByIsbn(string isbn)
        {
            return products.Where(product =>  product.Isbn == isbn)
                           .ToArray();
        }

        public Product[] GetAllByTitleOrAuthor(string query)
        {
            return products.Where(product => product.Author.Contains(query)
                                          || product.Title.Contains(query))
                           .ToArray();
                                           
        }
    }
}
