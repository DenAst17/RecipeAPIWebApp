namespace RecipeAPIWebApp.Models
{
    public class Category
    {
        public Category()
        {
            Recipes = new List<Recipe>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
