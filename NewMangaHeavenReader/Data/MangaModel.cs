namespace NewMangaHeavenReader.Data
{
    public class MangaModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Admin"; //Potentially remove?

        //May not need this
        public string? FileName { get; set; } //Includes path to file location


    }
}
