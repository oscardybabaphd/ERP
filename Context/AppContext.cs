using CubebarnERP.Models;
using IdentityModels.Models.Entities;
using IdentityModels.Models.Entities.AuditModel;
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
        public DbSet<SiteMapParentNode> SiteMapParentNode { get; set; }
        public DbSet<SiteMapSubParentNode> SiteMapSubParentNode { get; set; }
        public DbSet<SiteMapUrlLabel> SiteMapUrlLabel { get; set; }
        public DbSet<AuditModel> AuditRecords { get; set; }
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
