using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using af.assessment.api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace af.assessment.api.Data
{
    public class RegisterDbContext : DbContext
    {
        public RegisterDbContext(DbContextOptions<RegisterDbContext> options)
       : base(options)
        {
        }

      
        public virtual DbSet<Member> Members { get; set; }
      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
