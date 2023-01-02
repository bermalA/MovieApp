using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppHopefullyLast.Models
{
    public class ActorMovie
    {
        [Key]
        public int ActorMovieId { get; set; }
        [ForeignKey("Movie")]
        public int? MovieId { get; set; }
        public Movie Inmovie { get; set; }
        [ForeignKey("Actor")]
        public int? ActorId { get; set; }
        public Actor Acted { get; set; }

    }
}
