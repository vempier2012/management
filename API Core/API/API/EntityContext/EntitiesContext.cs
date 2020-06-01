using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.EntityContext
{
    public class EntitiesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("TestDatabaseDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Faculty
            modelBuilder.Entity<Faculty>().HasKey(f => new { f.faculty_code });
            modelBuilder.Entity<Faculty>().Property(f => f.faculty_code).HasMaxLength(10);
            modelBuilder.Entity<Faculty>().Property(f => f.faculty_name).HasMaxLength(150);

            //Major
            modelBuilder.Entity<Major>().HasKey(m => new { m.major_code });
            modelBuilder.Entity<Major>()
                .HasOne(f => f.Faculties)
                .WithMany(m => m.Majors)
                .HasForeignKey("faculty_code");
            modelBuilder.Entity<Major>().Property(m => m.major_code).HasMaxLength(10);
            modelBuilder.Entity<Major>().Property(m => m.major_name).HasMaxLength(150);



            //bang Student
            modelBuilder.Entity<Student>().HasKey(s => new { s.student_code });
            modelBuilder.Entity<Student>().Property(s => s.student_code).IsRequired();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<StudentMajor> StudentMajors { get; set; }
        public DbSet<Attendence> Attendences { get; set; }
        public DbSet<ActivityEventCategory> ActivityEventCategories { get; set; }
        public DbSet<ActivityEventList> ActivityEventLists { get; set; }
    }
}
