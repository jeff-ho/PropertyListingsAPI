namespace PropertyListingsApi.Services.ListingService
{
    public class ListingService : IListingService
    {

        private static List<Listing> propertyListings = new List<Listing>
           {
               new Listing {Id=1, Title="Nice Place", Description="Super nice place", AgentName="John Smith", Address="123 Street", Bedrooms= 3, Bathrooms= 3, Price= 100000},
               new Listing {Id=2, Title="Second Place", Description="Second Super nice place", AgentName="Jenny Smith", Address="312 Street", Bedrooms= 5, Bathrooms= 5, Price= 1800000},
           };
        public List<Listing> AddListing(Listing listing)
        {
            propertyListings.Add(listing);

            return propertyListings;
        }

        public List<Listing>? DeleteListing(int id)
        {
            var listing = (propertyListings.Find(x => x.Id == id));

            if (listing is null) return null;

            propertyListings.Remove(listing!);

            return propertyListings;
        }

        public List<Listing> GetAllListings()
        {
            return propertyListings;
        }

        public Listing? GetSingleListing(int id)
        {
            var listing = propertyListings.Find(x => x.Id == id);

            if (listing is null) return null;

            return listing;
        }

        public List<Listing>? UpdateListing(int id, Listing listingRequest)
        {
            var listing = propertyListings.Find(x => x.Id == id);

            if (listing is null) return null;

            listing.Title = listingRequest.Title;
            listing.Description = listingRequest.Description;
            listing.AgentName = listingRequest.AgentName;
            listing.Address = listingRequest.Address;
            listing.Bedrooms = listingRequest.Bedrooms;
            listing.Bathrooms = listingRequest.Bathrooms;
            listing.Price = listingRequest.Price;

            return propertyListings;
        }
    }
}
