using Microsoft.AspNetCore.Mvc;
using PropertyListingsApi.Models;
using PropertyListingsApi.Services.ListingService;
using System.Reflection;

namespace PropertyListingsApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PropertyListingsController : ControllerBase
    {

        private readonly ListingService _listingService;    
        public PropertyListingsController(IListingService listingService)
        {
            _listingService = listingService;
        }

        [HttpGet]

        public async Task<ActionResult<List<Listing>>> GetAllListings()
        {
            var result = _listingService.GetAllListings();

            return Ok(result);
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Listing>> GetSingleListing(int id)
        {
            var result = _listingService.GetSingleListing(id);

            return Ok(result);
        }


        [HttpPost]

        public async Task<ActionResult<List<Listing>>> AddListing(Listing listing)
        {
            var result = _listingService.AddListing(listing);

            return Ok(result);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Listing>>> UpdateListing(int id, Listing listingRequest)
        {
            var result = _listingService.UpdateListing(id, listingRequest);

            if (result is null) return NotFound("Listing not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Listing>>> DeleteListing(int id)
        {
            var result = _listingService.DeleteListing(id);

            if (result is null) return NotFound("Listing not found");

            return Ok(result);

        }
    }
}
