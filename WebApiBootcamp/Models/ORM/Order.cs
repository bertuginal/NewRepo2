namespace WebApiBootcamp.Models.ORM
{
    public class Order : BaseModel
    {
        public int OrderNumber { get; set; }
        public double TotalPrice { get; set; }
        public List<WebUser> Users { get; set; }
    }
}
