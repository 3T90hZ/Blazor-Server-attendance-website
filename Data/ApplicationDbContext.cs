    using AttendanceApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    namespace AttendanceApp.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(a => a.ClassSchedule)
                .WithMany(cs => cs.Attendances)
                .HasForeignKey(a => a.ClassScheduleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
