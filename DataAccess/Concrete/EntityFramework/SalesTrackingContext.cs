using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class SalesTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=salestracking;trusted_connection=true;");
        }

        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Packet> Packets { get; set; }
    }
}
