using Microsoft.EntityFrameworkCore;

namespace VehicleRental
{
    public class DatabaseContext : DbContext {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}