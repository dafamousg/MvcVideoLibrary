using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcICT.Models
{
    public class Video
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public required string Title { get; set; }

        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? Genre { get; set; }
        public string? Rating { get; set; }
    }
}
