namespace WebApiBootcamp.Models
{
    public class Product
    {
        public Product(int productId, string productName, double unitPrice, Category category) {
        
            this.ProductId = productId;
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.Category = category;
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public Category Category { get; set; }
    }


}
