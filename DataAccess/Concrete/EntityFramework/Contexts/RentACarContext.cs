﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RentACarContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public RentACarContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
