namespace FetchHandler.Fetch
{
    public class UserFetchData
    {
        public string UserId { get; set; }
        public string AccessToken { get; }

        public UserFetchData(string i_UserId, string i_AccessToken)
        {
            UserId = i_UserId;
            AccessToken = i_AccessToken;
        }
    }
}
