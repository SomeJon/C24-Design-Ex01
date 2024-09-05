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
        private List<PostTypeAnalysis> m_PostTypeAnalyses;
        public List<UpdatedPostData> PostData { get; set; }
        public List<UpdatedPostData> Top5Posts
        {
            get
            {
                return PostData
                    .OrderByDescending(post => post.NumOfLikes + post.NumOfComments)
                    .Take(5)
                    .ToList();
            }
        }
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
        public int TotalDays
        {
            get
            {
                if (PostData == null || PostData.Count == 0)
                {
                    return 0;
                }

                DateTime minDate = PostData.Min(post => post.CreatedTime).GetValueOrDefault();
                DateTime maxDate = PostData.Max(post => post.CreatedTime).GetValueOrDefault();

                return (maxDate - minDate).Days + 1; // Adding 1 to include the first and last day
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
        public double PostFrequency
        {
            get
            {
                return PostData.Count() / (TotalDays);
            }
        }
        public Dictionary<string, double> PostTimingImpact
        {
            get
            {
                Dictionary<string, double> timingImpact = new Dictionary<string, double>();

                for (int hour = 0; hour < 24; hour++)
                {
                    List<UpdatedPostData> postsAtHour = PostData.Where(post => post.CreatedTime.HasValue && post.CreatedTime.Value.Hour == hour).ToList();
                    if (postsAtHour.Count > 0)
                    {
                        double averageEngagement = postsAtHour.Average(post => (double)(post.NumOfLikes + post.NumOfComments));
                        timingImpact.Add($"Hour {hour}", averageEngagement);
                    }
                }

                return timingImpact;
            }
        }
        public List<PostTypeAnalysis> PostTypeAnalyses 
        { 
            get
            {
                if(m_PostTypeAnalyses == null)
                {
                    m_PostTypeAnalyses = analyzePostTypes();
                }

                return m_PostTypeAnalyses;
            } 
        }

        private List<PostTypeAnalysis> analyzePostTypes()
        {
            List<PostTypeAnalysis> analysisResults = new List<PostTypeAnalysis>();

            var postGroups = PostData.GroupBy(post => post.Type);

            foreach (var group in postGroups)
            {
                string postType = group.Key.ToString();
                int totalLikes = group.Sum(post => post.NumOfLikes);
                int totalComments = group.Sum(post => post.NumOfComments);
                double averageEngagement = (double)(totalLikes + totalComments) / group.Count();

                analysisResults.Add(new PostTypeAnalysis
                {
                    PostType = postType,
                    TotalLikes = totalLikes,
                    TotalComments = totalComments,
                    AverageEngagement = averageEngagement
                });
            }

            return analysisResults;
        }
    }
}
