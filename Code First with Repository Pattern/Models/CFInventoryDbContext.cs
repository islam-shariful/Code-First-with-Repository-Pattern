using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_with_Repository_Pattern.Models
{
    public class CFInventoryDbContext : DbContext
    {
        public CFInventoryDbContext() : base("CFInventoryDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CFInventoryDbContext>());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}