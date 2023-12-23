namespace WebApiBootcamp.Models
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product(1, "Honda", 1000000, new Category(1, "Car")));
            products.Add(new Product(2, "Laptop", 20000, new Category(2, "Technology")));
            products.Add(new Product(3, "Renault", 2000000, new Category(1, "Car")));
            products.Add(new Product(4, "Hamburger", 70, new Category(3, "Fast Food")));

            return products;
        }
    }
}
