using FacebookPages.Code.Pages.Data.Post;
using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FacebookPages.Code.Pages.Data
{
    public class PostAnalyticData : PageData, IPageData
    {
        private List<PostTypeAnalysis> m_PostTypeAnalyses;
        public List<UpdatedPostData> PostData { get; set; }
        public List<UpdatedPostData> Top5Posts =>
            PostData
                .OrderByDescending(i_Post => i_Post.NumOfLikes + i_Post.NumOfComments)
                .Take(5)
                .ToList();

        public int TotalLikes => PostData.Sum(i_Post => i_Post.NumOfLikes);

        public int TotalComments => PostData.Sum(i_Post => i_Post.NumOfComments);

        public int TotalDays
        {
            get
            {
                if (PostData == null || PostData.Count == 0)
                {
                    return 0;
                }

                DateTime minDate = PostData.Min(i_Post => i_Post.CreatedTime)
                    .GetValueOrDefault();
                DateTime maxDate = PostData.Max(i_Post => i_Post.CreatedTime)
                    .GetValueOrDefault();

                return (maxDate - minDate).Days + 1; // Adding 1 to include the first and last day
            }
        }
        public double AverageEngagementRate
        {
            get
            {
                List<double> engagementRates = PostData.Select
                    (i_Post => (double)(i_Post.NumOfLikes + i_Post.NumOfComments)).ToList();
                return engagementRates.Average();
            }
        }
        public double PostFrequency => (float)PostData.Count() / (float)(TotalDays);

        public Dictionary<string, double> PostTimingImpact
        {
            get
            {
                Dictionary<string, double> timingImpact = new Dictionary<string, double>();

                for (int hour = 0; hour < 24; hour++)
                {
                    List<UpdatedPostData> postsAtHour = 
                        PostData
                            .Where(i_Post => i_Post.CreatedTime.HasValue && i_Post.CreatedTime.Value.Hour == hour)
                            .ToList();

                    if (postsAtHour.Count > 0)
                    {
                        double averageEngagement = 
                            postsAtHour
                                .Average(i_Post => (double)(i_Post.NumOfLikes + i_Post.NumOfComments));

                        timingImpact.Add($"Hour {hour}", averageEngagement);
                    }
                }

                return timingImpact;
            }
        }
        public List<PostTypeAnalysis> PostTypeAnalyses => m_PostTypeAnalyses ?? (m_PostTypeAnalyses = analyzePostTypes());

        private List<PostTypeAnalysis> analyzePostTypes()
        {
            List<PostTypeAnalysis> analysisResults = new List<PostTypeAnalysis>();

            var postGroups = PostData.GroupBy(i_Post => i_Post.Type);

            foreach (var group in postGroups)
            {
                string postType = group.Key.ToString();
                int totalLikes = group.Sum(i_Post => i_Post.NumOfLikes);
                int totalComments = group.Sum(i_Post => i_Post.NumOfComments);
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
