/*
 * [2019] - [2021] Eblocks Software (Pty) Ltd, All Rights Reserved.
 * NOTICE: All information contained herein is, and remains the property of Eblocks
 * Software (Pty) Ltd.
 * and its suppliers (if any). The intellectual and technical concepts contained herein
 * are proprietary
 * to Eblocks Software (Pty) Ltd. and its suppliers (if any) and may be covered by South 
 * African, U.S.
 * and Foreign patents, patents in process, and are protected by trade secret and / or 
 * copyright law.
 * Dissemination of this information or reproduction of this material is forbidden unless
 * prior written
 * permission is obtained from Eblocks Software (Pty) Ltd.
*/

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

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Member>().HasMany(v => v.FamilyMember).WithOne().HasForeignKey(l => l.Id);

            //modelBuilder.Entity<Appointment>().HasData(SeedData.SeedAppointments());
            //modelBuilder.Entity<FamilyMember>().HasData(SeedData.SeedFamilyMembers());
            //modelBuilder.Entity<Vaccine>().HasData(SeedData.SeedVaccines());
            //modelBuilder.Entity<Member>().HasData(SeedData.SeedMember());
            //modelBuilder.Entity<Location>().HasData(SeedData.SeedLocation()); 
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
