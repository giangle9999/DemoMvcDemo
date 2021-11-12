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
                        EmployeeName = ("Dinh Thế Nhân"),
                        PhoneNumber = "09129899100",
                       
                    },

                    new Employee
                    {
                         EmployeeID = "EMP002",
                        EmployeeName = ("Phạm Văn Anh"),
                        PhoneNumber = "09139899100",
                    },

                    new Employee    
                    {
                        EmployeeID = "EMP003",
                        EmployeeName = ("Nguyễn Quang Đức"),
                        PhoneNumber = "09149899100",
                    },

                    new Employee    
                    {
                        EmployeeID = "EMP004",
                        EmployeeName = ("Vũ Văn Lâm"),
                        PhoneNumber = "09159899100",
                    
                    }
                );
                context.SaveChanges();
            }
        }
    }
}