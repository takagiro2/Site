namespace Site.Models
{
    public class Book
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public required long AuthorId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
