namespace BookStoreAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using BookStoreAPI.Models;
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set;}
    }
}
