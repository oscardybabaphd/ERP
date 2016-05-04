using IdentityModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContext
{
    public class AppContextClass : DbContext
    {
        public AppContextClass()
            : base("DefaultConnection")
        {

        }
        public DbSet<Demo> Demos { get; set; }
        public DbSet<AccountingEntry> AccountingEntry { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static AppContextClass Create()
        {
            var context = new AppContextClass();
            context.Configuration.LazyLoadingEnabled = false;
            return context;
        }
    }
}
