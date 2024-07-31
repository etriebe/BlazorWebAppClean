using AspNetCore.Identity.CosmosDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DeafultWebApp.Data;

public class ApplicationDbContext : CosmosIdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public ApplicationDbContext(DbContextOptions dbContextOptions)
          : base(dbContextOptions) { }
}
