

namespace PropertyListingsApi.Services.ListingService
{
    public class ListingService : IListingService
    {

        private static List<Listing> propertyListings = new List<Listing>
           {
               new Listing {Id=1, Title="Nice Place", Description="Super nice place", AgentName="John Smith", Address="123 Street", Bedrooms= 3, Bathrooms= 3, Price= 100000},
               new Listing {Id=2, Title="Second Place", Description="Second Super nice place", AgentName="Jenny Smith", Address="312 Street", Bedrooms= 5, Bathrooms= 5, Price= 1800000},
           };

        private readonly DataContext _context;
        public ListingService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Listing>> AddListing(Listing listing)
        {
            _context.Listings.Add(listing);

            await _context.SaveChangesAsync();

            return await _context.Listings.ToListAsync();
        }

        public async Task<List<Listing>?> DeleteListing(int id)
        {
            var listing = await _context.Listings.FindAsync(id);

            if (listing is null) return null;

            _context.Listings.Remove(listing!);
            await _context.SaveChangesAsync();

            return await _context.Listings.ToListAsync();
        }

        public async Task<List<Listing>> GetAllListings()
        {
            var listings = await _context.Listings.ToListAsync();
            return listings;
        }

        public async Task<Listing?> GetSingleListing(int id)
        {
            var listing = await _context.Listings.FindAsync(id);

            if (listing is null) return null;

            return listing;
        }

        public async Task<List<Listing>?> UpdateListing(int id, Listing listingRequest)
        {
            var listing = await _context.Listings.FindAsync(id);

            if (listing is null) return null;

            listing.Title = listingRequest.Title;
            listing.Description = listingRequest.Description;
            listing.AgentName = listingRequest.AgentName;
            listing.Address = listingRequest.Address;
            listing.Bedrooms = listingRequest.Bedrooms;
            listing.Bathrooms = listingRequest.Bathrooms;
            listing.Price = listingRequest.Price;

            await _context.SaveChangesAsync();

            return await _context.Listings.ToListAsync();
        }
    }
}
