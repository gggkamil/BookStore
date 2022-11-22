namespace E_commerce.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Decscription { get; set; }
        public string ISBN { get; set;}
        public decimal price { get; set; }
        public string PictureUri { get; set; }
        public int BookAuthorId { get; set; }
        public BookAuthor BookAuthor { get; set; }
        public int BookStoreId { get; set; }
        public Bookstore Bookstore { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
