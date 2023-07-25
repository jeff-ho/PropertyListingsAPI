using Microsoft.EntityFrameworkCore;
using PropertyListingsApi.Models;

namespace PropertyListingsApi.Data
{
    public class DataContextEF: DbContext
    {
        private readonly IConfiguration _config;

        public DataContextEF(IConfiguration config)
        {
            _config = config;
        }

        public virtual DbSet<Listing> Listings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
