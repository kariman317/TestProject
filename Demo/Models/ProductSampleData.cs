using System.Collections.Generic;

namespace Demo.Models
{
    public class ProductSampleData
    {
        List<Product> products = new List<Product>();
        public ProductSampleData()
        {
            products = new List<Product>();
            products.Add(new Product() { Id=1,NAme="Iphone",Price=2000,Image="1.jpg"});
            products.Add(new Product() { Id = 2, NAme = "Nokia", Price = 20000, Image = "2.jpg" });
            products.Add(new Product() { Id = 3, NAme = "Samsong", Price = 10000, Image = "3.jpg" });
        }
        public List<Product> Products()
        {
            return products;
        }
    }
}
