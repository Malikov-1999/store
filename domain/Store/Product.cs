using System;

namespace Store;

public class Product
{
    public int Id { get; }
    public string SKU { get; }
    public string? Name { get; }
   
    public Product(int id, string sku)
    {
        Id = id;
        SKU = sku;
    }

}
