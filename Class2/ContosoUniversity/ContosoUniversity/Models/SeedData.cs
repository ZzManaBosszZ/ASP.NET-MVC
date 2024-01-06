using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Data;
using System;
using System.Linq;

namespace ContosoUniversity.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SchoolContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SchoolContext>>()))
        {
            // Look for any movies.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
            context.Students.AddRange(
                new Student
                {
                 FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),
    
            
                },
                new Student
                {
                    FirstMidName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2002-09-01")
                },
                new Student
                {
                    FirstMidName = "Arturo",
                    LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2003-09-01")
                },
                new Student
                {
                    FirstMidName = "Gytis",
                    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2002-09-01")
                }
            );

            context.Courses.AddRange(
               new Course
               {
                   CourseID = 1050,
                   Title = "Chemistry",
                   Credits = 3


               },
               new Course
               {
                   CourseID = 4022,
                   Title = "Microeconomics",
                   Credits = 3
               },
               new Course
               {
                   CourseID = 2042,
                   Title = "Literature",
                   Credits = 4
               },
               new Course
               {
                   CourseID = 3141,
                   Title = "Trigonometry",
                   Credits = 4
               }
           );

            context.Enrollments.AddRange(
               new Enrollment
               {
                   StudentID = 1,
                   CourseID = 1050,
                   Grade = Grade.A


               },
               new Enrollment
               {
                   StudentID = 1,
                   CourseID = 4022,
                   Grade = Grade.C
               },
               new Enrollment
               {
                   StudentID = 2,
                   CourseID = 2021,
                   Grade = Grade.F
               },
               new Enrollment
               {
                   StudentID = 6,
                   CourseID = 1045
               }
           );
            context.SaveChanges();
        }
    }
}