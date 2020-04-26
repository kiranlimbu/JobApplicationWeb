using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationPoster.Models;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationPoster.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> StudentTable { get; set; }
        public DbSet<Application> ApplicationTable { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    AutoId = 1,
                    FullName = "Emily Park",
                    Address = "635 Brighton Circle Road",
                    Title = "Student",
                    Total = 7
                },
                new Student
                {
                    AutoId = 2,
                    FullName = "Hyo Bae",
                    Address = "4323 Jerome Avenue",
                    Title = "Team Leader",
                    Total = 11
                },
                new Student
                {
                    AutoId = 3,
                    FullName = "Paul Schultz",
                    Address = "2553 Pin Oak Drive",
                    Title = "Software Engineer",
                    Total = 9
                }
            );

            modelBuilder.Entity<Application>().HasData(
               new Application
               {
                   Identy = 1,
                   StudentId = 1,
                   Company = "Amazon",
                   Title = "Software Engineer",
                   Location = "Virginia",
                   Sticker = 1
               },
               new Application
               {
                   Identy = 2,
                   StudentId = 1,
                   Company = "Microsoft",
                   Title = "Software Engineer",
                   Location = "Virginia",
                   Sticker = 1
               },
               new Application
               {
                   Identy = 3,
                   StudentId = 2,
                   Company = "Amazon",
                   Title = "Software Engineer",
                   Location = "Seattle, WA",
                   Sticker = 1
               },
               new Application
               {
                   Identy = 4,
                   StudentId = 2,
                   Company = "North Gruman",
                   Title = "Software Engineer",
                   Location = "California",
                   Sticker = 1
               },
               new Application
               {
                   Identy = 5,
                   StudentId = 3,
                   Company = "North Gruman",
                   Title = "Software Engineer",
                   Location = "California",
                   Sticker = 1
               }
           );
        }
    }
}
