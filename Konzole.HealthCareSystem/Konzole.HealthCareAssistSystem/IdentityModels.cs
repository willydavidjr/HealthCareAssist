using System.Data.Entity;
using System.Dynamic;
using System.Security.Claims;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Konzole.HealthCareAssistSystem.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("CareerConnection", throwIfV1Schema: false)
        {
        }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionChoices> QuestionChoices { get; set; }
        public virtual DbSet<LogMessage> LogMessage { get; set; }
      
        public virtual  DbSet<User> Users { get; set; }
        public virtual DbSet <UserRole> UserRoles { get; set; }
        public virtual DbSet<JobList> JobList { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}