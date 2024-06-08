using LAB12_TINOCO_DAEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB12_TINOCO_DAEA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet(Name = "List")]
        public List<Person> List(string firstName)
        {
            List<Person> people = new();

            for (int i = 1; i <= 100; i++) 
            {
                people.Add(new Person(i, $"Jacko{i}", $"Tinoco{i}", $"Calle {i}"));
            }

            return people.Where(x => x.FirstName == firstName).ToList();
        }

        [HttpPost(Name = "List2")]
        public List<Person> List2([FromBody]Person person)
        {
            List<Person> people = new();

            for (int i = 1; i <= 100; i++)
            {
                people.Add(new Person(i, $"Jacko{i}", $"Tinoco{i}", $"Calle {i}"));
            }

            return people.Where(x => x.FirstName == person.FirstName).ToList();
        }
    }
}