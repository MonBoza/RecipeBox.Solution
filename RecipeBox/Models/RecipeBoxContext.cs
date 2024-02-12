using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
    public DbSet<Item> Items { get; set; }
 
    public RecipeBoxContext(DbContextOptions options) : base(options) { }
  }
}