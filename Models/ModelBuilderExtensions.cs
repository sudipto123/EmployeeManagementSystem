using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Sudipto",
                   Department = Dept.IT,
                   Email = "sudipto@gmail.com"
               },
               new Employee
               {
                   Id = 2,
                   Name = "Pradipto",
                   Department = Dept.HR,
                   Email = "pradipto@gmail.com"
               },
               new Employee
               {
                   Id = 3,
                   Name = "Puneet",
                   Department = Dept.HR,
                   Email = "puneet@gmail.com"
               }
           );
        }
    }
}
