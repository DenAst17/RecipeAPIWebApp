using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace RecipeAPIWebApp.Models
{
    public class RecipeAPIContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Like> Like { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientCascade;
            }
        }

        public RecipeAPIContext(DbContextOptions<RecipeAPIContext> options)
        : base(options)
        {

        }
    }
}
