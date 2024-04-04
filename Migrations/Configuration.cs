namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToDoList.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoList.Models.ApplicationDbContext context) // this is taking in a data context
        {
            // This method is called whenever we create a database 

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            // context.People.AddUpdate(
            // p -> p.FullName,
            // new Person {FullName = "Andrew Peters"},
            // new Person {FullName = "Brice Lambson"},
            // new Person {FullName = " Rowan Miller"}
            // );

            AddUsers(context); 
        }

        // function to add users

        void AddUsers(ToDoList.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user@email.com" }; // user names and email addresses will be the same in this system
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            um.Create(user, "password");
        }
    }
}


/* we are going to add a migration in order to run this:
 * open Package Manager Console
 * write: Add-Migration ToDo1*/