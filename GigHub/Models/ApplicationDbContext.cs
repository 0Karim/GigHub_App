using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace GigHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("GigHub_DB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Gig> Gig { set; get; }
        public DbSet<Genre> Genre { set; get; }
    }
}