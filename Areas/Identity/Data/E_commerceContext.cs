using E_commerce.Areas.Identity.Data;
using E_commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Data;

public class E_commerceContext : IdentityDbContext<E_commerceUser>
{
    public E_commerceContext(DbContextOptions<E_commerceContext> options)
        : base(options)
    {
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthor { get; set; }
    public DbSet<Bookstore> Bookstores { get; set; }
    public DbSet<Category> Categories { get; set; }

    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
