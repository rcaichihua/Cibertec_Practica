using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            //Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}
