using Microsoft.EntityFrameworkCore;
using petCare.Models;

namespace petCare.Data
{
    public class petCareDatabase:DbContext
    {
        public petCareDatabase(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
            
        }




        public DbSet<customerUser> customerUsers { get; set; }
        public DbSet<BusUser> busUsers { get; set; }
        public DbSet<Pet> pets { get; set; }
        public DbSet<Review> reviews { get; set; }
    }
}
