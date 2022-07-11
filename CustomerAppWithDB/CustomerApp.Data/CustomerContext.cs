using Microsoft.EntityFrameworkCore;
using CustomerApp.Domain;


namespace CustomerApp.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDb;" +
                                        "Initial Catalog=CustomerAppData");
        }
    }
}