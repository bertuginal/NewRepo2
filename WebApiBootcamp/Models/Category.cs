namespace WebApiBootcamp.Models
{
    public class Category
    {
        public Category(int categoryId, string categoryName) { 

            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            
            
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
