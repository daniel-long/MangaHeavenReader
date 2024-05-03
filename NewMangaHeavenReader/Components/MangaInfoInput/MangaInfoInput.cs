namespace NewMangaHeavenReader.Components.MangaInfoInput
{
    public class MangaInfoInput
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
    }
}
