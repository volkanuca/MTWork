using Microsoft.EntityFrameworkCore;
using MTWork.Entities;


namespace MTWork.DataAccess
{
    public class MTWorkDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
         
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=MTWorkDb;User Id=mtsa;Password=Mt2024++;TrustServerCertificate=True;MultipleActiveResultSets=true;");
#else
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=OyakDB;User Id=sa;Password=;TrustServerCertificate=True;MultipleActiveResultSets=true;");
#endif
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserRole> UserRoles{ get; set; }
        public DbSet<UserGroup> UserGroups{ get; set; }
        public DbSet<WorkItem> WorkItems{ get; set; }
        public DbSet<WorkItemDetail> WorkItemDetails { get; set; }



    }
}
