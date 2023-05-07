namespace RecipeAPIWebApp.Models
{
    public class User
    {
        public User()
        {
            Recipes = new List<Recipe>();
            Likes = new List<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
