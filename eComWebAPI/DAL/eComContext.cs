using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using eComWebAPI.ViewModels.User;

namespace eComWebAPI.DAL
{
    public class eComContext : DbContext
    {
        public eComContext() : base("eComContext")
        {
            Seed()
        }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
