using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : Controller
    {
        [HttpGet]
        public string[] Get()
        {
            string[] countries = new string[] {

                "Türkiye", "America", "United Kingdom", "Germany", "France", "Holland", "Spain", "Australia", "Russian", "China", "Japan",
                "Norway", "Brazil", "South Africa", "Argentina", "Mexico", "South Korea", "Canada", "India", "Belgium"
            };
            return countries;
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] countries = new string[] {

                "Türkiye", "America", "United Kingdom", "Germany", "France", "Holland", "Spain", "Australia", "Russian", "China", "Japan",
                "Norway", "Brazil", "South Africa", "Argentina", "Mexico", "South Korea", "Canada", "India", "Belgium"
            };

            string result = "";

            if (id < 0 || id >= countries.Length)
            {
                return "Invalid ID";
            }
            else
            {
                for (int i = 0; i < id; i++)
                {
                    result += countries[i] + "\n";
                }

            }

            return result;
        }
    }
}
