using System;
using System.Collections.Generic;

namespace FacebookDataWrapper
{
    public class PictureData
    {
        public int Height { get; set; }
        public bool IsSilhouette { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }

    public class Picture
    {
        public PictureData Data { get; set; }
    }

    public class Friend
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Picture Picture { get; set; }
    }

    public class Cursors
    {
        public string Before { get; set; }
        public string After { get; set; }
    }

    public class Paging
    {
        public Cursors Cursors { get; set; }
    }

    public class Summary
    {
        public int TotalCount { get; set; }
    }

    public class FacebookFriendsResponse
    {
        public List<Friend> Data { get; set; }
        public Paging Paging { get; set; }
    }
}
