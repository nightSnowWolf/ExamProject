﻿namespace CatAlog.Db.Models.VideoTemplate
{
    public class SubtitleInfo
    {
        public int Id { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
        
        public string Language { get; set; }

        public string Author { get; set; }

        public string SubtitleFormat { get; set; }

        public string Note { get; set; }
    }
}