using Core.Entities;
using Entities.Concrete;
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
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public RentACarContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public RentACarContext()
        {
        }

        //tabloların veri tabanındaki değişiklikleri burada override ederek yapıyoruz. Migration dosyasında değil.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Brand>().HasKey(i => i.Id).HasName("Markalar"); // Ef Core Naming Convention BrandId
            modelBuilder.Entity<Brand>(e =>
            {
                //e.ToTable("Markalar");
                e.HasKey(i => i.Id);
                e.Property(i => i.Premium).HasDefaultValue(true);

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
