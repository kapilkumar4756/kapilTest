namespace Jason_CRUD.Migrations
{
    using Jason_CRUD.Models;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Jason_CRUD.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Jason_CRUD.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any())
            {
                if (!context.Roles.Any())
                {
                    var store = new RoleStore<IdentityRole>(context);
                    var manager = new RoleManager<IdentityRole>(store);

                    var role1 = new IdentityRole { Name = "admin" };
                    var role2 = new IdentityRole { Name = "cmlpro" };
                    var role3 = new IdentityRole { Name = "tm" };
                    manager.Create(role1);
                    manager.Create(role2);
                    manager.Create(role3);
                }
            }
            if (!context.Users.Any())
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    UserName = "admin@admin.com",
                    EmailConfirmed = true,
                    PhoneNumber = "1234567890",
                    PhoneNumberConfirmed = true,
                };

                manager.Create(user, "Admin@1234");
                manager.AddToRole(user.Id, "admin");
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
