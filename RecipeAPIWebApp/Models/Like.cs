namespace RecipeAPIWebApp.Models
{
    public class Like
    {
        public Like()
        {

        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public virtual User? User { get; set; }
        public virtual Recipe? Recipe { get; set; }
    }
}
