using Microsoft.EntityFrameworkCore;
using MVCLibrary.Models;

namespace MVCLibrary
{
  public class LibraryContext : DbContext
  {
    public DbSet<Library> Libraries {get; set;}
    public DbSet<Book> Books {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder builder){
      builder.UseSqlite("Filename=./MVCLIBRARYDATA.db");
    }


  }
}