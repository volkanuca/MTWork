using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using MTWork.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace DataAccess
{
    public class MTWorkDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            //optionsBuilder.UseSqlServer(@"Data Source=.;Database=OyakDB;Integrated Security=true");
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

    }
}