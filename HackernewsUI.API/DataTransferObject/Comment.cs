namespace HackernewsUI.API.DataTransferObject
{
    public class Comment
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Type { get; set; }
        public string By { get; set; }
        public DateTime Created = DateTime.UtcNow;
        public string Text { get; set; }
    }
}
