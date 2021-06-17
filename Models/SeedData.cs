using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesStudent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesStudentContext>>()))
            {
                // Look for any Students.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        FirstName = "Angel",
                        LastName = "Alexander",
                        CertifiedDate = DateTime.Parse("1989-2-12"),
                        Location = "Chicago",
                        TandF = 8.99M,
                        Program = "coding"
                    },

                    new Student
                    {
                        FirstName = "Michael",
                        LastName = "Williams",
                        CertifiedDate = DateTime.Parse("1984-3-13"),
                        Location = "Hammond",
                        TandF = 8.99M,
                        Program = "sales"
                    },

                    new Student
                    {
                        FirstName = "Muhammad",
                        LastName = "Naaem",
                        CertifiedDate = DateTime.Parse("1986-2-23"),
                        Location = "Chicago",
                        TandF = 7.99M,
                        Program = "coding"
                    },

                    new Student
                    {
                        FirstName = "Mariah",
                        LastName = "Coleman",
                        CertifiedDate = DateTime.Parse("1959-4-15"),
                        Location = "Chicago",
                        TandF = 8.99M,
                        Program = "Recruiter"
                    },
                     new Student
                    {
                        FirstName = "Lauren",
                        LastName = "Mason",
                        CertifiedDate = DateTime.Parse("1959-4-15"),
                        Location = "Chicago",
                        TandF = 8.99M,
                        Program = "coding"
                    },
                    new Student
                    {
                        FirstName = "Darrell",
                        LastName = "Blue",
                        CertifiedDate = DateTime.Parse("1959-4-15"),
                        Location = "Chicago",
                        TandF = 8.99M,
                        Program = "Graphics"
                    },
                    new Student
                    {
                        FirstName = "Shawn",
                        LastName = "Coleman",
                        CertifiedDate = DateTime.Parse("1959-4-15"),
                        Location = "Chicago",
                        TandF = 8.99M,
                        Program = "coding"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}