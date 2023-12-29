using System.ComponentModel.DataAnnotations;
using WebApiBootcamp.Models.ORM;

namespace WebApiBootcamp.Models.ORM
{
    public class Blog : BaseModel
    {

        [MaxLength(50)]
        public string Title { get; set; }
        public string? Description { get; set; }

        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }


        public int? AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
