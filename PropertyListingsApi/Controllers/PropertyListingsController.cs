using Microsoft.AspNetCore.Mvc;
using PropertyListingsApi.Models;
using System.Security.Cryptography.X509Certificates;

namespace PropertyListingsApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PropertyListingsController : ControllerBase
    {

        private static List<Listing> propertyListings = new List<Listing>
           {
               new Listing {Id=1, Title="Nice Place", Description="Super nice place", AgentName="John Smith", Address="123 Street", Bedrooms= 3, Bathrooms= 3, Price= 100000},
               new Listing {Id=2, Title="Second Place", Description="Second Super nice place", AgentName="Jenny Smith", Address="312 Street", Bedrooms= 5, Bathrooms= 5, Price= 1800000},
           };

        [HttpGet]

        public async Task<ActionResult<List<Listing>>> GetAllListings()
        {

            return Ok(propertyListings);
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Listing>> GetSingleListing(int id)
        {
            return Ok(propertyListings.Find(x => x.Id == id));
        }


        [HttpPost]

        public async Task<ActionResult<List<Listing>>> AddListing(Listing listing)
        {
            propertyListings.Add(listing);

            return Ok(propertyListings);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Listing>>> UpdateListing(int id, Listing listingRequest)
        {
            var listing = propertyListings.Find(x => x.Id == id);

            if (listing is null) return NotFound("Sorry, this listing does not exist");

            listing.Title = listingRequest.Title;
            listing.Description = listingRequest.Description;
            listing.AgentName = listingRequest.AgentName;
            listing.Address = listingRequest.Address;
            listing.Bedrooms = listingRequest.Bedrooms;
            listing.Bathrooms = listingRequest.Bathrooms;
            listing.Price = listingRequest.Price;

            return Ok(propertyListings);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Listing>>> DeleteListing(int id)
        {
            var listing = (propertyListings.Find(x => x.Id == id));

            if (listing is null) return NotFound("Sorry, listing does not exist");

            propertyListings.Remove(listing!);

            return Ok(propertyListings);

        }
    }
}
