using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBootcamp.Models.ORM;

namespace WebApiBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        TechCareerDbContext _context;

        public StudentController()
        {
            _context = new TechCareerDbContext();
        }


        [HttpGet]
        public IActionResult Get()
        {
            var students = _context.Students.Include(x => x.Courses).ToList();
            return Ok(students);
        }
    }
}
