using System.Collections.Generic;

namespace Portfolio.Models
{
    public class GameItem
    {
        public string Slug { get; set; } = "";
        public string Title { get; set; } = "";
        public string BannerImage { get; set; } = "";
        public List<string> Stack { get; set; } = new();
        public string Description { get; set; } = "";
        public GameStats Stats { get; set; } = new();
        public string CtaText { get; set; } = "Learn More";
        public string CtaHref { get; set; } = "#";
    }

    public class GameStats
    {
        public string? DownloadsKey { get; set; }   // allow null, we handle it
        public string? Rating { get; set; }
        public double TimeSeconds { get; set; }
        public int GamesPlayed { get; set; }
        public int Jumps { get; set; }
        public double DistanceMeters { get; set; }
    }

}
