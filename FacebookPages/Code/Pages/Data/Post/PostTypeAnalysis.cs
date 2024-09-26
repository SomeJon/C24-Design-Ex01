namespace FacebookPages.Code.Pages.Data.Post
{
    public class PostTypeAnalysis
    {
        public string PostType { get; set; }
        public int TotalLikes { get; set; }
        public int TotalComments { get; set; }
        public double AverageEngagement { get; set; }

        public override string ToString()
        {
            return PostType;
        }
    }
}
