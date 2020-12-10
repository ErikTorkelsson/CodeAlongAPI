using CodeAlongAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlongAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentID, sc.CourseID });

            modelBuilder.Entity<StudentCourse>().HasOne(sc => sc.Student).WithMany(sc => sc.StudentCourses).HasForeignKey(sc => sc.StudentID);

            modelBuilder.Entity<StudentCourse>()
              .HasOne(sc => sc.Course)
              .WithMany(s => s.StudentCourses)
              .HasForeignKey(sc => sc.CourseID);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
