using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppHopefullyLast.Models
{
    public class DirectorMovie
    {
        [Key]
        public int DirectorMovieId { get; set; }
        [ForeignKey("Movie")]
        public int? MovieId { get; set; }
        public Movie Themovie { get; set; }
        [ForeignKey("Director")]
        public int? DirectorId { get; set; }
        public Director Directed { get; set; }
    }
}
