using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcICT.Models
{
    public class VideoGenreViewModel
    {
        public List<Video>? Videos { get; set; }
        public SelectList? Genre { get; set; }
        public string? VideoGenre { get; set; }
        public string? searchString { get; set; }
    }
}
