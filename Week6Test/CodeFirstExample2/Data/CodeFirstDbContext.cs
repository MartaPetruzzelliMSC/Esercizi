using CodeFirstExample2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample2.Data
{
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Giacomo", Surname = "Marchisio", Email = "jack@example.com" },
                new Student { Id = 2, Name = "Claudio", Surname = "Raciti", Email = "claudio@example.com" },
                new Student { Id = 3, Name = "Giulio", Surname = "Pappalardo", Email = "giulio@example.com" }
            );
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Italiano" },
                new Course { Id = 2, Name = "Inglese" },
                new Course { Id = 3, Name = "Storia" }
            );

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity(
                    "StudentCourses",
                    r => r.HasOne(typeof(Course)).WithMany().HasForeignKey("CourseId").HasPrincipalKey(nameof(Course.Id)),
                    l => l.HasOne(typeof(Student)).WithMany().HasForeignKey("StudentId").HasPrincipalKey(nameof(Student.Id)),
                    j => j.HasKey("StudentId", "CourseId"));

            modelBuilder.Entity("StudentCourses").HasData(
                new { StudentId = 1, CourseId = 1 },
                new { StudentId = 1, CourseId = 2 },
                new { StudentId = 2, CourseId = 2 },
                new { StudentId = 2, CourseId = 3 },
                new { StudentId = 3, CourseId = 1 },
                new { StudentId = 3, CourseId = 3 }
            );

        }
    }
}
