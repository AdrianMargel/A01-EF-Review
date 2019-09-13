using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    //DbContext is a "virtual" representation of the database
    //WestWindcontext inherits from the DbContext class
    public class WestWindContext : DbContext
    {
        //parameterless constructor will first call the constructor of the base class that takes a string value
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            //we are telling EF to NOT generate the db or tables
            Database.SetInitializer<WestWindContext>(null);
            //we can prevent database initialization in code (like we are doing here), or we can prevent it through settings in the .config
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        public DbSet<Addresses> Addresses{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ManifestItem> ManifestItem { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Territory> Territories { get; set; }

        // TODO: Practice - Add entities and DbSet<> properties for the remaining tables
    }
}
