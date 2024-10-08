using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapperEnhancements.Code.Collection;

namespace FacebookWrapperEnhancements.Code.EnhancedObjects
    {
    public class EnhancedUser : User
    {
        private FacebookObjectCollection<EnhancedUser> m_Friends;
        private FacebookObjectCollectionWithPaging<EnhancedPost> m_Posts;
        private FacebookObjectCollectionWithPaging<EnhancedPost> m_Feed;
        private static readonly Dictionary<eLoadOptions, string> sr_FieldsToLoadV900 = new Dictionary<eLoadOptions, string>
            {
                {
                    eLoadOptions.None,
                    "id, name"
                },
                {
                    eLoadOptions.Basic,
                    "id, name,gender, birthday, about, age_range, email, first_name, last_name, relationship_status, religion, significant_other, cover"
                },
                {
                    eLoadOptions.Full,
                    "id, name,gender, birthday, about, age_range, email, first_name, last_name, relationship_status, religion, significant_other, cover,favorite_athletes, favorite_teams, inspirational_people, install_type, installed, interested_in, languages, locale, meeting_for, middle_name, name_format, political, quotes, sports, third_party_id, timezone, updated_time, video_upload_limits, website, accounts, verified, link, location{location}, currency, education, work, devices, hometown"
                },
                {
                    eLoadOptions.FullWithConnections,
                    "id, name,gender, birthday, about, age_range, email, first_name, last_name, relationship_status, religion, significant_other, cover,favorite_athletes, favorite_teams, inspirational_people, install_type, installed, interested_in, languages, locale, meeting_for, middle_name, name_format, political, quotes, sports, third_party_id, timezone, updated_time, video_upload_limits, website, accounts, verified, link, location{location}, currency, education, work, devices,groups, events, friends, albums, likes, hometown"
                }
            };
        protected override Dictionary<eLoadOptions, string> FieldsToLoad => sr_FieldsToLoad;
        public new static Dictionary<eLoadOptions, string> sr_FieldsToLoad => sr_FieldsToLoadV900;
        public new FacebookObjectCollection<EnhancedUser> Friends
        {
            get => RetrieveCollection("friends", ref m_Friends, FieldsToLoad[eLoadOptions.Full]);
            set => m_Friends = value;
        }
        public new FacebookObjectCollectionWithPaging<EnhancedPost> Posts
        {
            get => FacebookServicesEnhancements.RetrieveCollection("posts?", ref m_Posts, Id, EnhancedPost.sr_FieldsToLoad[eLoadOptions.Full]);
            set => m_Posts = value;
        }
        public FacebookObjectCollectionWithPaging<EnhancedPost> Feed
        {
            get => FacebookServicesEnhancements.RetrieveCollection("feed?", ref m_Feed, Id, EnhancedPost.sr_FieldsToLoad[eLoadOptions.Full]);
            set => m_Feed = value;
        }

    }
}
