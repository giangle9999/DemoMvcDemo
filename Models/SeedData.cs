using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Demo.Data;

namespace Demo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DemoDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DemoDBContext>>()))
            {
                // Look for any movies.
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employees.AddRange(
                    new Employee
                    {
                        EmployeeID = "EMP001",
                        EmployeeName = ("Lê Nhật Giang"),
                        PhoneNumber = "09129899100",
                       
                    },

                    new Employee
                    {
                         EmployeeID = "EMP002",
                        EmployeeName = ("Lê Đẳng Hai"),
                        PhoneNumber = "09139899100",
                    },

                    new Employee    
                    {
                        EmployeeID = "EMP003",
                        EmployeeName = ("Phùng Thanh Lịch"),
                        PhoneNumber = "09149899100",
                    },

                    new Employee    
                    {
                        EmployeeID = "EMP004",
                        EmployeeName = ("Trần Thái Linh Hương"),
                        PhoneNumber = "09159899100",
                    
                    }
                );
                context.SaveChanges();
            }
        }
    }
}