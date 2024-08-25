using System.Collections.Generic;

namespace FacebookPostData
{
    public class PostResponse
    {
        public List<PostData> Data { get; set; }
        public PagingInfo Paging { get; set; }
    }

    public class PostData
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public string CreatedTime { get; set; }
        public string UpdatedTime { get; set; }
        public string FullPicture { get; set; }
        public string Link { get; set; }
        public Attachments Attachments { get; set; }
        public FromUser From { get; set; }
        public Reactions Reactions { get; set; }
        public Comments Comments { get; set; }
        public string StatusType { get; set; }
        public string Type { get; set; }
        public Application Application { get; set; }
    }

    public class Attachments
    {
        public List<AttachmentData> Data { get; set; }
    }

    public class AttachmentData
    {
        public Media Media { get; set; }
        public Target Target { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public SubAttachments SubAttachments { get; set; }
    }

    public class Media
    {
        public Image Image { get; set; }
    }

    public class Image
    {
        public int Height { get; set; }
        public string Src { get; set; }
        public int Width { get; set; }
    }

    public class Target
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class SubAttachments
    {
        public List<AttachmentData> Data { get; set; }
    }

    public class FromUser
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Reactions
    {
        public List<ReactionData> Data { get; set; }
        public ReactionSummary Summary { get; set; }
        public ReactionPaging Paging { get; set; }
    }

    public class ReactionData
    {
        // Add properties here if needed
    }

    public class ReactionSummary
    {
        public int TotalCount { get; set; }
        public string ViewerReaction { get; set; }
    }

    public class ReactionPaging
    {
        public Cursors Cursors { get; set; }
    }

    public class Cursors
    {
        public string Before { get; set; }
        public string After { get; set; }
    }

    public class Comments
    {
        public List<CommentData> Data { get; set; }
        public CommentSummary Summary { get; set; }
    }

    public class CommentData
    {
        // Add properties here if needed
    }

    public class CommentSummary
    {
        public string Order { get; set; }
        public int TotalCount { get; set; }
        public bool CanComment { get; set; }
    }

    public class Application
    {
        public string Namespace { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class PagingInfo
    {
        public string Previous { get; set; }
        public string Next { get; set; }
    }
}
