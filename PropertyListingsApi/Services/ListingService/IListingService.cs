namespace PropertyListingsApi.Services.ListingService
{
    public interface IListingService
    {
        Task<List<Listing>> GetAllListings();

        Task<Listing?> GetSingleListing(int id);

        Task<List<Listing>> AddListing(Listing listing);

        Task<List<Listing>?> UpdateListing(int id, Listing listingRequest);

       Task<List<Listing>?> DeleteListing(int id);

    };
}
