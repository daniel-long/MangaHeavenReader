
using Microsoft.EntityFrameworkCore;

namespace NewMangaHeavenReader.Data
{
    public class inputMangaDBContext:DbContext
    {
        public inputMangaDBContext(DbContextOptions<inputMangaDBContext> options) : base(options) { }
   
        public DbSet<MangaInfo> Mangas { get; set; }
    }

    public class MangaInfo
    {
        public string? Title {  get; set; }
        public string? Author{ get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
    }
}
