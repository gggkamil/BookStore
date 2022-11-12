﻿namespace E_commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre{ get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
