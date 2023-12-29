using System.ComponentModel.DataAnnotations;

namespace WebApiBootcamp.Models.ORM
{
    public class Author : BaseModel
    {

        [MaxLength(50)]
        public string Name { get; set; }
        public string? Surname { get; set; }
    }
}
