using AspNetCore.Identity.CosmosDb;
using Microsoft.EntityFrameworkCore;

namespace DeafultWebApp.Data;

public class ApplicationDbContext : CosmosIdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public ApplicationDbContext(DbContextOptions dbContextOptions)
          : base(dbContextOptions) { }
}
