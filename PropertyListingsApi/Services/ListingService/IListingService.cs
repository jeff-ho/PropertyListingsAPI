namespace PropertyListingsApi.Services.ListingService
{
    public interface IListingService
    {
        List<Listing> GetAllListings();

        Listing? GetSingleListing(int id);

        List<Listing> AddListing(Listing listing);

        List<Listing>? UpdateListing(int id, Listing listingRequest);

        List<Listing>? DeleteListing(int id);

    };
}
