namespace FacebookPages.Code.Pages.Data
{
    public class UserFetchData
    {
        public string UserId { get; set; }
        public string AccessToekn { get; }

        public UserFetchData(string iUserId, string iAccessToekn)
        {
            UserId = iUserId;
            AccessToekn = iAccessToekn;
        }
    }
}
