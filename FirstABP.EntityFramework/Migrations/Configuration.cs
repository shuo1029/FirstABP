using System.Data.Entity.Migrations;
using System.Linq;
using System;

namespace FirstABP.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FirstABP.EntityFramework.FirstABPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FirstABP";
        }

        protected override void Seed(FirstABP.EntityFramework.FirstABPDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            var userAdmin = context.User.FirstOrDefault(m => m.UserName.ToLower() == "admin");
            if (userAdmin == null)
            {
                context.User.Add(new Core.Entities.User() { CreateTime = DateTime.Now, IsDeleted = false, UserName = "admin", Password = "111111", IsEnabled = true, UpdateTime = DateTime.Now });
                context.SaveChanges();
            }
        }
    }
}
