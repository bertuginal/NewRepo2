using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBootcamp.Models.ORM;

namespace WebApiBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        TechCareerDbContext _context;

        public OrderController() { 
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var orders = _context.orders.Include(x => x.Users).ToList();
                return Ok(orders);
        }
    }
}
