
using Microsoft.EntityFrameworkCore;
namespace ELibrary.Models

{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Fine> Finess { get; set; }
        public DbSet<Librarian> Librarians { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        
    }
}
