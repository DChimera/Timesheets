using Microsoft.EntityFrameworkCore;

namespace TimesheetsApp.Entities
{
    public class TimesheetsDbContext : DbContext
    {
        public TimesheetsDbContext(DbContextOptions<TimesheetsDbContext> options)
            : base(options)
        {
        }



        // Add your properties for accessing your entities here...
        public DbSet<Timesheet> Timesheets { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Do your initializing/seeding here...
            modelBuilder.Entity<Timesheet>().HasData(

                new Timesheet { TimesheetId = 1, Date = new DateTime(2022, 10, 18), ProjectName = "New Build", Hours = 20 },
                new Timesheet { TimesheetId = 2, Date = new DateTime(2022, 10, 18), ProjectName = "Bug Fix", Hours = 9 },
                new Timesheet { TimesheetId = 3, Date = new DateTime(2022, 10, 18), ProjectName = "Quality Assurance", Hours = 28 }


                );
        }
    }
}
