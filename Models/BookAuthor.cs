﻿namespace E_commerce.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set;}
        public ICollection<Book> Books { get; set; }

    }
}
