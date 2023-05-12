namespace HackernewsUI.API.DataTransferObject
{
    public class Story
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string By { get; set; }
        public string Title { get; set; }
        public int Descendants { get; set; }
    }
}
