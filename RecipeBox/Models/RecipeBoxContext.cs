using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<RecipeTag> RecipeTags { get; set; }
 
    public RecipeBoxContext(DbContextOptions options) : base(options) { }
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   base.OnModelCreating(builder);
    //   // Customize the ASP.NET Identity model and override the defaults if needed.
    //   // For example, you can rename the ASP.NET Identity table names and more.
    //   // Add your customizations after calling base.OnModelCreating(builder);
    //   builder.Entity<ApplicationUser>()
    //   .Property(e => e.Name)
    //   .HasMaxLength(250);
    // }
  }
  
}