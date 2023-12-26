using WebApiBootcamp.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace WebApiBootcamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public EmployeeController()
        {
            _context = new TechCareerDbContext();
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _context.Employees.ToList();
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {

            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employee == null) {

                return NotFound();
            }

            else {

                return Ok(employee);
            }

        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employee.AddDate = DateTime.Now;
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status201Created, employee);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            var updateEmployee = _context.Employees.Find(id);

            if (updateEmployee == null)
            {
                return NotFound();
            }

            updateEmployee.FirstName = employee.FirstName;
            updateEmployee.LastName = employee.LastName;
            updateEmployee.Address = employee.Address;
            updateEmployee.City = employee.City;
            updateEmployee.BirthDate = employee.BirthDate;
            updateEmployee.UpdateDate = DateTime.Now;

            _context.Employees.Update(updateEmployee);
            _context.SaveChanges();
            return Ok(updateEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employee == null) {

                return NotFound();
            }
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return Ok(employee);
            }
        }
    }
}
