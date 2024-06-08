using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LAB12_TINOCO_DAEA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<string> Get()
        {
            List<string> products = new List<string>();
            products.Add("keyboard");

            return products;
        }

        [HttpGet(Name = "GetProducts")]
        public List<string> GetProducts()
        {
            List<string> products = new List<string>();
            products.Add("mouse");

            return products;
        }

        [HttpGet(Name = "GetProducts50")]
        public List<string> GetProducts50()
        {
            List<string> products = new List<string>();
            products.Add("laptop");

            return products;
        }
    }
}
