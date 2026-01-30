using Microsoft.EntityFrameworkCore;
using ParkingPermitService.Models;

namespace ParkingPermitService.Data
{
    //Adding AppDbContext Class for the creation of the database
        public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Db name set as the student parking permit 
        public DbSet<StudentParkingPermit> StudentParkingPermits => Set<StudentParkingPermit>();
    }
}
