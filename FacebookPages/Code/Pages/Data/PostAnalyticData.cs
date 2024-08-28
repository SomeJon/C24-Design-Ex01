using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages;
using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookPages.Code.Pages.Data
{
    public class PostAnalyticData : PageData, IPageData
    {
        public List<UpdatedPostData> PostData { get; set; }
        public int TotalLikes
        {
            get
            {
                return PostData.Sum(post => post.NumOfLikes);
            }
        }
        public int TotalComments
        {
            get
            {
                return PostData.Sum(post => post.NumOfComments);
            }
        }
        public double AverageEngagementRate
        {
            get
            {
                List<double> engagementRates = PostData.Select
                    (post => (double)(post.NumOfLikes + post.NumOfComments)).ToList();
                return engagementRates.Average();
            }
        }

        public void calcEngagement()
        {
            int totalLikes = PostData.Sum(post => post.NumOfLikes);
            int totalComments = PostData.Sum(post => post.NumOfComments);
            List<double> engagementRates = PostData.Select
                (post => (double)(post.NumOfLikes + post.NumOfComments)).ToList();
            double averageEngagementRate = engagementRates.Average();
        }
    }
}
