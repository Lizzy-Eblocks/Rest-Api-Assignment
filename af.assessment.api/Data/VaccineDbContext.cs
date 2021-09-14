using af.assessment.api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace af.assessment.api.Data
{
    public class VaccineDbContext : DbContext
    {
        public VaccineDbContext(DbContextOptions<VaccineDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Appointment>().HasMany(v => v.Vaccines).WithOne().HasForeignKey(l => l.Id);
            
            // modelBuilder.Entity<Appointment>().HasData(SeedData.SeedAppointments());
            // modelBuilder.Entity<FamilyMember>().HasData(SeedData.SeedFamilyMembers());
            // modelBuilder.Entity<Vaccine>().HasData(SeedData.SeedVaccines());
            // modelBuilder.Entity<Member>().HasData(SeedData.SeedMember());
            // modelBuilder.Entity<Location>().HasData(SeedData.SeedLocation());
        }
    }
}