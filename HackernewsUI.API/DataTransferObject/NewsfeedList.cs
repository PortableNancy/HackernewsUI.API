namespace HackernewsUI.API.DataTransferObject
{
    public class NewsfeedList : PagingInformation
    {
        public Newsfeed? Newsfeed { get; set; }
        public Support? Support { get; set; }
    }
}
