namespace Site.Models
{
    public class Library
    {
        public long Id { get; set; }
        public string Name { get; set; } = "NoName library";
        public Book[]? Books { get; set; }
    }
}
