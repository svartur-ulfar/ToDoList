using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


/* this model was created by, when the project was created. when we choosw "user authentication.
 * so it created the models, views and controllers.*/

/* This identity model is a model for identity*/



namespace ToDoList.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

/* the following class refers to data access layer*/
/* here we have its inheriting identity, so it's gonna be a data base of users
 * with all the various things set for them*/


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        /* we are going to add a table for ToDos"
         */

        public DbSet<ToDo> ToDos { get; set; } /* this is part of data acces layer, so it's gonna
         be a collection of todos that are in a table in this database*/
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}

/* by putting this table in the user's table information,
 * things are gonna be easier when we start doing things like:
 * migration and we think about appointment*/

/*technically the constructor is telling what connection or where this database is*/



/* after that we enable a migration sistem because is not abeld by default
 * open up Package Manager Console
 * write: Enable-Migrations 
 * this is going to look at what db arein our application and it's gonna find 
 * the one that was in Identity Models and it's gonna make a bunch of classes*/
