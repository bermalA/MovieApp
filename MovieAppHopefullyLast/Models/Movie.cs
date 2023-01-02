using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAppHopefullyLast.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Category { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        public int DirectorMovieId { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string MovieDescription { get; set; }
    }
}
