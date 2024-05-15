namespace AD_Book_Shop.Models.Book
{
    public class BookService
    {
        // Class object
        public Guid Id { get; set; }
        public string BookName { get; set;}
        public string Author { get; set;}
        public string ISBN { get; set;}
        public string Description { get; set;}
        public string Price { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set;}
    }
}
