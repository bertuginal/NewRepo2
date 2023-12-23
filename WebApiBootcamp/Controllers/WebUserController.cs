using Microsoft.AspNetCore.Mvc;
using WebApiBootcamp.Models;

namespace WebApiBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserController : Controller
    {
        static List<WebUser> webusers;

        public WebUserController()
        {
            if (webusers == null)
                webusers = WebUserService.GetWebUsers();
        }

        //getAll
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(webusers);
        }

        //getById
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var webuser = webusers.FirstOrDefault(x => x.Id == id);

            if (webuser == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(webuser);
            }
        }

        //Disarinda bir webuser nesnesi alip, onu listeye ekleyecek create
        [HttpPost]
        public IActionResult Post(WebUser webuser)
        {
            webuser.Id = webusers.Count + 1;
            webusers.Add(webuser);

            return StatusCode(StatusCodes.Status201Created, webuser);
        }

        //delete by id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var webuser = webusers.FirstOrDefault(x => x.Id == id);

            if (webuser == null)
            {
                return NotFound();
            }
            else
            {
                webusers.Remove(webuser);
                return Ok(webuser);
            }
        }
    }
}
