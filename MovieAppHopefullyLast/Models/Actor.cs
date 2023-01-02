using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAppHopefullyLast.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ActorName { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string ActorDescription { get; set; }
    }
}
