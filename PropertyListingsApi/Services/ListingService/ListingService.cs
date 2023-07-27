

namespace PropertyListingsApi.Services.ListingService
{
    public class ListingService : IListingService
    {

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
            listing.Size = listingRequest.Size;
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
