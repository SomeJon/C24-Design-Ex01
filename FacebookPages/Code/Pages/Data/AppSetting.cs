using System.Collections.Generic;

namespace FacebookPages.Code.Pages.Data
{
    public static class AppSetting
    {
        public static string AppId { get; set; } = "867142571975316";
        public static List<string> AppIds { get; } = new List<string>()
                                                  {
                                                      "867142571975316", 
                                                      "696056928008003", 
                                                      "1450160541956417",
                                                  };
        public static string[] Permissions { get; } = new string[]
                                                          {
                                                              "email", "public_profile", "user_age_range",
                                                              "user_birthday", "user_friends", "user_gender",
                                                              "user_hometown", "user_likes", "user_link",
                                                              "user_location", "user_photos", "user_posts",
                                                              "user_videos"
                                                          };
    }
}