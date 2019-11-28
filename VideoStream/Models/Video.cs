using System;
using SQLite;
using VideoStream.Commands;

namespace VideoStream.Models
{
    public class Video
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string User { get; set; }
        public string NumberOfView { get; set; }
        public string WhenViewed { get; set; }
        public string VideoLink { get; set; }
        public string VideoThumbNailLink { get; set; }
    }
}
