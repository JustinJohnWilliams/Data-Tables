using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTables.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }

    public class CustomerRepo
    {
        public static IQueryable<Customer> Customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "John Doe", Email = "john.doe@doe.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 2, Name = "Jane Doe", Email = "Jane.doe@doe.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 3, Name = "Bill Smith", Email = "Bill_Smith123@yahoo.com", Address = "1 Road Circle Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 4, Name = "Aaron Meeks", Email = "AMeeks@gmail.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 5, Name = "Bob Jones", Email = "B12Jones@gmail.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 6, Name = "Mary Jones", Email = "momma_jones@jones.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 7, Name = "Trey Parker", Email = "t_park@yahoo.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 8, Name = "Troy Aikman", Email = "number8@cowboys.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 9, Name = "Jeff Ridges", Email = "Ridge$23@gmail.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 10, Name = "Billy Jean", Email = "jean@gmail.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 11, Name = "Matt Stone", Email = "cartman@southpark.net", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 12, Name = "Bat Man", Email = "robin_reads_this@bats.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 13, Name = "Zoey Williams", Email = "1zw1@yahoo.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 14, Name = "Rick Durango", Email = "colorado@ski.net", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 15, Name = "Will Smith", Email = "Agent_J@mib.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 16, Name = "Mr T", Email = "pity@thefool.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 17, Name = "Em Inem", Email = "slim@shady.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 18, Name = "Debra Johnson", Email = "johnson_deb@gmail.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 19, Name = "Dorothy Jones", Email = "butterfiles1954@aol.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 20, Name = "John Cash", Email = "hurt@mib.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true },
            new Customer { Id = 21, Name = "Robin Parker", Email = "rparker@yahoo.com", Address = "1234 Main Street Dallas, TX", Phone = "(555) 123-4567", Active = true }
        }.AsQueryable();

    }
}