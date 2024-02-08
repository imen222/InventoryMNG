using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace InventoryMNG.Model
{
    internal class DbStockContext : DbContext
    {
        
        public DbStockContext() : base("name=DbStockContext")
        {
            Database.SetInitializer<DbStockContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Spécifiez le schéma correct ici (par exemple, "public" pour PostgreSQL)
            modelBuilder.Entity<admin>().ToTable("admin", "public");

            // Ajoutez d'autres configurations si nécessaire
        }


        public DbSet<admin> admins { get; set; }

        
    }
}
