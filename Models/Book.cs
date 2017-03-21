namespace MVCLibrary.Models
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public bool Available { get; set; }
        public int Id { get; set; }
        public int pages { get; set; }
        public int Published { get; set; }
        public Library Library { get; set; }
    }
}