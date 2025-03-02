namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid GenreId { get; set; }  
        public Genre? Genre { get; set; }
    }

}