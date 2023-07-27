namespace PropertyListingsApi.Models
{
    public class Listing
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Size { get; set; }

        public string Description { get; set; }= string.Empty;

        public string AgentName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int Bedrooms { get; set; } 

        public int Bathrooms { get; set; }  

        public int Price { get; set; }  
    }
}
