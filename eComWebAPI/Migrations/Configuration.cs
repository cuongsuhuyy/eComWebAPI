namespace eComWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eComWebAPI.DAL.eComContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eComWebAPI.DAL.eComContext context)
        {
            context.Users.AddOrUpdate(new ViewModels.User.UserModel()
            {
                Id = new Guid(),
                Username = "test",
                Email = "test@gmail.com",
                Password = "test"
            });
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
