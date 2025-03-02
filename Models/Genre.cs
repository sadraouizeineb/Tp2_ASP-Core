namespace MovieApp.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // Ajouter cette ligne pour représenter la relation inverse (One-to-Many)
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

