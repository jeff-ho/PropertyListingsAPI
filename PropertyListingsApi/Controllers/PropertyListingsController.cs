using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace PropertyListingsApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PropertyListingsController : ControllerBase
    {
        public PropertyListingsController() { }

        [HttpGet("{listing}")]

        public string[] GetListings(string listing) {

            return new string[]
            {
                "user1", "user2", listing
            };
        
        }
    }
}
