using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace NewMangaHeavenReader.Data
{
    public class MangaInfoDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=mangaheavenreader.database.windows.net;Initial Catalog=Manga_Heaven_Reader;Persist Security Info=True;User ID=MangaAdmin;Password=***********;Encrypt=True;Database= Manga_Info") ;
        }

        public DbSet<Title> Manga_Info { get; set; }
    
    }

    public class Description
    {
    }
}
