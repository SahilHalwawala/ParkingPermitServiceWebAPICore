using Microsoft.EntityFrameworkCore;
using ParkingPermitService.Models;

namespace ParkingPermitService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<StudentParkingPermit> StudentParkingPermits => Set<StudentParkingPermit>();
    }
}
