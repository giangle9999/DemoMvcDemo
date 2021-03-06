using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Models;
namespace Demo.Data{

    public class DemoDBContext : DbContext
    {
        public DemoDBContext (DbContextOptions<DemoDBContext> options)
            : base(options)
        {
            
            
        }

        public DbSet<Demo.Models.Person> Person { get; set; }

        public DbSet<Demo.Models.Student> Students { get; set; }

        public DbSet<Demo.Models.Employee> Employees { get; set; }

        public DbSet<Demo.Models.Product> Products { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Student1> Student1 { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product1> Product1 { get; set; }
        

        

        

        
    }
}
