using System;
using System.Collections.Generic;

namespace FacebookPostsWrapper
{
    public class FacebookPostWrapper
    {
        public Posts posts { get; set; }
        public string id { get; set; }
    }

    public class Posts
    {
        public List<PostData> data { get; set; }
        public Paging paging { get; set; }
    }

    public class PostData
    {
        public string id { get; set; }
        public string message { get; set; }
        public string created_time { get; set; }
        public string updated_time { get; set; }
        public string full_picture { get; set; }
        public string link { get; set; }
        public Attachments attachments { get; set; }
        public From from { get; set; }
        public Comments comments { get; set; }
        public string status_type { get; set; }
        public string type { get; set; }
    }

    public class Attachments
    {
        public List<AttachmentData> data { get; set; }
    }

    public class AttachmentData
    {
        public Media media { get; set; }
        public Target target { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public List<SubAttachment> subattachments { get; set; }
    }

    public class Media
    {
        public Image image { get; set; }
        public string source { get; set; }
    }

    public class Image
    {
        public int height { get; set; }
        public string src { get; set; }
        public int width { get; set; }
    }

    public class Target
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class SubAttachment
    {
        public Media media { get; set; }
        public string type { get; set; }
    }

    public class From
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Comments
    {
        public List<CommentData> data { get; set; }
        public CommentSummary summary { get; set; }
    }

    public class CommentData
    {
        public string message { get; set; }
        public From from { get; set; }
        public string created_time { get; set; }
    }

    public class CommentSummary
    {
        public int total_count { get; set; }
        public bool can_comment { get; set; }
        public string order { get; set; }
    }

    public class Paging
    {
        public string previous { get; set; }
        public string next { get; set; }
    }
}
